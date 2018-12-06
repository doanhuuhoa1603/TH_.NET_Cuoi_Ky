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
    public partial class NuocSXForm : Form
    {
        public delegate void dd();
        public dd ShowForm;
        NuocSX_BLL NSX_BLL;
        public NuocSXForm()
        {
            InitializeComponent();
            NSX_BLL = new BLL.NuocSX_BLL();
        }

        private void NuocSXForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowForm();
            Dispose();
        }
        private void ShowNuocSX()
        {
            dgv.DataSource = NSX_BLL.Show_BLL();
        }
        private void Reload()
        {
            ShowNuocSX();
            this.Visible = true; // Hien thi lai form
        }
        private void but_Show_Click(object sender, EventArgs e)
        {
            ShowNuocSX();
        }

        private void but_Search_Click(object sender, EventArgs e)
        {
            dgv.DataSource = NSX_BLL.Show_BLL(txt_Search.Text);
        }

        private void but_Update_Click(object sender, EventArgs e)
        {
            if (txtMaNSX.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Nước cần sửa!");
            }
            else
            {
                Boolean result = NSX_BLL.updateTS(new DTO.NuocSX
                {
                    MaNuocSX = Convert.ToInt32(txtMaNSX.Text),
                    TenNuocSX = txtTenNSX.Text
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
            dgv.DataSource = NSX_BLL.Show_BLL(); // Refresh lai du lieu tren DataGridView
        }

        private void but_Delete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một hàng cần xóa!");
            }
            else
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa (các) hàng đã chọn?",
                         "Xác nhận xóa dữ liệu!",
                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Add MaTS cua cac hang duoc chon vao list
                    List<int> l = new List<int>();
                    foreach (DataGridViewRow r in dgv.SelectedRows)
                    {
                        l.Add(Convert.ToInt32(r.Cells["MaNuocSX"].Value.ToString()));
                    }
                    Boolean result = NSX_BLL.deleteTS(l);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại. Vui lòng thử lại sau!");
                    }
                    dgv.DataSource = NSX_BLL.Show_BLL(); // Refresh lai du lieu tren DataGridView
                }
            }
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            NuocSXAddform f = new NuocSXAddform();
            f.ReloadData += Reload;
            f.Show();
            this.Visible = false; // Tam an form
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<DTO.NuocSX> l = NSX_BLL.getNSXByID(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaNuocSX"].Value.ToString()));
            txtMaNSX.Text = l[0].MaNuocSX.ToString();
            txtTenNSX.Text = l[0].TenNuocSX.ToString();
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            ShowForm();
            Dispose();
        }
    }
}