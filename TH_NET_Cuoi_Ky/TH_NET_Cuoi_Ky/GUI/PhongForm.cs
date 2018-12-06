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
    public partial class PhongForm : Form
    {
        public delegate void dd();
        public dd ShowForm;
        NguoiQL_BLL NQL_BLL;
        Phong_BLL Phong_BLL;
        public PhongForm()
        {
            InitializeComponent();
            this.Phong_BLL = new Phong_BLL();
            NQL_BLL = new NguoiQL_BLL();
            loadCBB();
        }
        private void loadCBB()
        {
            foreach (string i in NQL_BLL.loadcbb())
            {
                if (comboBox1.FindStringExact(i) < 0)
                    comboBox1.Items.Add(i);
            }
        }
        private void PhongForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowForm();
        }

        private void ShowPhong()
        {
            dgv.DataSource = Phong_BLL.ShowPhong_BLL();
        }

        private void BntShowPhong_Click(object sender, EventArgs e)
        {
            ShowPhong();
        }

        private void Reload()
        {
            ShowForm();
            this.Visible = true;
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            PhongAddForm f = new PhongAddForm();
            f.ReloadPhong += Reload;
            f.Show();
            this.Visible = false;
        }

        private void but_Update_Click(object sender, EventArgs e)
        {
            if (txt_MaPhong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Phòng cần sửa!");
            }
            else
            {
                Boolean result = Phong_BLL.UpdatePhong(new DTO.Phong
                {
                    MaPhong = Convert.ToInt32(txt_MaPhong.Text),
                    TenPhong = txt_TenPhong.Text,
                    MaNguoiQL = Phong_BLL.GetMaNQL(comboBox1.SelectedItem.ToString())
                    
                });
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại sau!");
                }
            }
            ShowPhong();
        }

        private void but_Delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa (các) người quản lý đã chọn?",
                                     "Xác nhận xóa dữ liệu!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                List<int> l = new List<int>();
                foreach (DataGridViewRow r in dgv.SelectedRows)
                {
                    l.Add(Convert.ToInt32(r.Cells["MaPhong"].Value.ToString()));
                }
                Boolean result = Phong_BLL.DeletePhong(l);
                if (result)
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Vui lòng thử lại sau!");
                }
                ShowPhong();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<DTO.Phong> l = Phong_BLL.getPhongById(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaPhong"].Value.ToString()));
            txt_MaPhong.Text = l[0].MaPhong.ToString();
            txt_TenPhong.Text = l[0].TenPhong;
            comboBox1.SelectedItem = l[0].NguoiQL.TenNguoiQL;
        }

        private void but_Search_Click(object sender, EventArgs e)
        {
            dgv.DataSource = Phong_BLL.ShowPhong_BLL(txt_Search.Text);
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            ShowForm();
            Dispose();
        }
    }
}