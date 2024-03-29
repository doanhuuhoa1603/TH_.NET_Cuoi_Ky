﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_NET_Cuoi_Ky.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ShowForm()
        {
            this.Visible = true;
        }
        private void btnTS_Click(object sender, EventArgs e)
        {
            TSForm f = new TSForm();
            f.ShowMainForm += ShowForm;
            f.Show();
            this.Visible = false;
        }

        private void btnLoaiTS_Click(object sender, EventArgs e)
        {
            LoaiTSForm f = new LoaiTSForm();
            f.BackToPreviousForm += ShowForm;
            f.Show();
            this.Visible = false;
        }

        private void btnNguoiQL_Click(object sender, EventArgs e)
        {
            NguoiQLForm f = new NguoiQLForm();
            f.BackToPreviousForm += ShowForm;
            f.Show();
            this.Visible = false;
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            PhongForm f = new PhongForm();
            f.BackToPreviousForm += ShowForm;
            f.Show();
            this.Visible = false;
        }

        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            NhapXuatForm f = new NhapXuatForm();
            f.BackToPreviousForm += ShowForm;
            f.Show();
            this.Visible = false;
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            NhaCCForm f = new NhaCCForm();
            f.BackToPreviousForm += ShowForm;
            f.Show();
            this.Visible = false;
        }

        private void btnNuocSX_Click(object sender, EventArgs e)
        {
            NuocSXForm f = new NuocSXForm();
            f.BackToPreviousForm += ShowForm;
            f.Show();
            this.Visible = false;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
