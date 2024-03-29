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
        public dd BackToPreviousForm;
        NguoiQL_BLL NQL_BLL;
        Phong_BLL Phong_BLL;
        public PhongForm()
        {
            InitializeComponent();
            this.Phong_BLL = new Phong_BLL();
            NQL_BLL = new NguoiQL_BLL();
        }
        //private void loadCBB()
        //{
        //    foreach (string i in NQL_BLL.loadcbb())
        //    {
        //        if (cbbNguoiQL.FindStringExact(i) < 0)
        //            cbbNguoiQL.Items.Add(i);
        //    }
        //}
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
            ShowPhong();
            this.Visible = true;
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            PhongAddForm f = new PhongAddForm();
            f.BackToPreviousForm += Reload;
            f.ShowDialog();
            //this.Visible = false;
        }

        private void but_Update_Click(object sender, EventArgs e)
        {
            if (txt_MaPhong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Phòng cần sửa!");
                return;
            }
            if(txt_TenPhong.Text == "" || cbbNguoiQL.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            (bool result, string msg) = Phong_BLL.updatePhong(new DTO.Phong
            {
                MaPhong = Convert.ToInt32(txt_MaPhong.Text),
                TenPhong = txt_TenPhong.Text,
                MaNguoiQL = Phong_BLL.getIdByName(cbbNguoiQL.SelectedItem.ToString())
                    
            });

            MessageBox.Show(msg, result ? "Thành công" : "Lỗi");

            ShowPhong();
        }

        private void but_Delete_Click(object sender, EventArgs e)
        {
            this.deleteToolStripMenuItem_Click(sender, e);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            updateToolStripMenuItem_Click(sender, e);
        }

        private void but_Search_Click(object sender, EventArgs e)
        {
            dgv.DataSource = Phong_BLL.SearhPhong_BLL(txt_Search.Text);
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            BackToPreviousForm();
            Dispose();
        }

        private void PhongForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToPreviousForm();
            Dispose();
        }

        private void menuDGV_Opening(object sender, CancelEventArgs e)
        {
            var cms = sender as ContextMenuStrip;
            var mousepos = Control.MousePosition;
            if (cms != null)
            {
                var rel_mousePos = cms.PointToClient(mousepos);
                if (cms.ClientRectangle.Contains(rel_mousePos))
                {
                    // Neu menu duoc mo bang chuot
                    var dgv_rel_mousePos = dgv.PointToClient(mousepos);
                    var hti = dgv.HitTest(dgv_rel_mousePos.X, dgv_rel_mousePos.Y);
                    if (hti.RowIndex == -1)
                    {
                        // Huy su kien khi khong co hang nao
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void dgv_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgv.HitTest(e.X, e.Y);
                dgv.ClearSelection();
                if (hti.RowIndex != -1)
                {
                    dgv.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DTO.Phong> l = Phong_BLL.getPhongById(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaPhong"].Value.ToString()));
            txt_MaPhong.Text = l[0].MaPhong.ToString();
            txt_TenPhong.Text = l[0].TenPhong;
            cbbNguoiQL.SelectedItem = l[0].NguoiQL.TenNguoiQL;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
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
                (bool result, string msg) = Phong_BLL.deletePhong(l);

                MessageBox.Show(msg, result ? "Thành công" : "Lỗi");

                ShowPhong();
            }
        }

        private void loadCBB_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string i in NQL_BLL.loadcbb())
            {
                if (cbbNguoiQL.FindStringExact(i) < 0)
                    cbbNguoiQL.Invoke(new Action(() => {
                        cbbNguoiQL.Items.Add(i);
                    }));
            }
        }

        private void PhongForm_Shown(object sender, EventArgs e)
        {
            loadCBB.RunWorkerAsync();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count > 0)
            {
                but_Update.Enabled = true;
                but_Delete.Enabled = true;
            }
            else
            {
                but_Update.Enabled = false;
                but_Delete.Enabled = false;
            }
        }

        private void PhongForm_KeyDown(object sender, KeyEventArgs e)
        {
            // To hop Ctrl + N => Tao moi
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                this.but_Add_Click(sender, e);
            }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) // Neu bam nut Delete khi dang o tren dgv
            {
                this.deleteToolStripMenuItem_Click(sender, e);
            }
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.but_Search_Click(sender, e);
            }
        }

        private void chiTietPhongStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietPhongForm f = new ChiTietPhongForm();
            f.ShowPhongForm += Reload;
            f.setLabel(dgv.SelectedRows[0].Cells["TenPhong"].Value.ToString(), dgv.SelectedRows[0].Cells["TenNguoiQL"].Value.ToString());
            f.setMaPhong(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaPhong"].Value.ToString()));
            f.ShowPhongDetail();
            f.Show();
            this.Visible = false;
        }
    }
}
