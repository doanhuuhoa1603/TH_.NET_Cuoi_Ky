﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH_NET_Cuoi_Ky.BLL;

namespace TH_NET_Cuoi_Ky.GUI
{
    public partial class PhongAddForm : Form
    {
        Phong_BLL Phong_BLL;
        NguoiQL_BLL NguoiQL_BLL;
        public delegate void dd();
        public delegate void dd2(String s);
        public dd BackToPreviousForm;
        public dd2 returnTenPhong;
        private bool allow = false;
        public PhongAddForm()
        {
            InitializeComponent();
            Phong_BLL = new Phong_BLL();
            NguoiQL_BLL = new NguoiQL_BLL();          
        }
        public void allowtoReturnTenPhong(bool value)
        {
            this.allow = value;
        }
        private void but_OK_Click(object sender, EventArgs e)
        {
            if(txtTenPhong.Text == "" || cbbNguoiQL.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            List<DTO.Phong> l = new List<DTO.Phong>();
            l.Add(new DTO.Phong {
                TenPhong = txtTenPhong.Text,
                MaNguoiQL = Phong_BLL.getIdByName(cbbNguoiQL.SelectedItem.ToString())
            });
            (bool result, string msg) = Phong_BLL.addPhong(l);
            if (result)
            {
                // Neu add thanh cong thi hien lai Form Tai San
                BackToPreviousForm();
                if (this.allow) returnTenPhong(txtTenPhong.Text);
                Dispose();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi");
            }
        }
        //private void loadCBB()
        //{
        //    foreach(string i in NguoiQL_BLL.loadcbb())
        //    {
        //        if (cbbNguoiQL.FindStringExact(i) < 0)
        //            cbbNguoiQL.Items.Add(i);
        //    }
        //}

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            //BackToPreviousForm();
            Dispose();
        }

        private void PhongAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //BackToPreviousForm();
            Dispose();
        }

        private void PhongAddForm_Shown(object sender, EventArgs e)
        {
            loadCBB.RunWorkerAsync();
        }

        private void loadCBB_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string i in NguoiQL_BLL.loadcbb())
            {
                if (cbbNguoiQL.FindStringExact(i) < 0)
                {
                    cbbNguoiQL.Invoke(new Action(() => {
                        cbbNguoiQL.Items.Add(i);
                    }));
                }
            }
        }

        private void PhongAddForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter de add
            {
                this.but_OK_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape) // Thoat neu nhan Esc
            {
                this.but_Cancel_Click(sender, e);
            }
        }
    }
}
