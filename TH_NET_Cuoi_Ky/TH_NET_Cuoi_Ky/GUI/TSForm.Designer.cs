﻿namespace TH_NET_Cuoi_Ky
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label6 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbLoaiTS1 = new System.Windows.Forms.ComboBox();
            this.cbbNuocSX1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbbLoaiTS = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbNuocSX = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.butShow = new System.Windows.Forms.Button();
            this.txtTskt = new System.Windows.Forms.TextBox();
            this.txtDvTinh = new System.Windows.Forms.TextBox();
            this.txtTenTS = new System.Windows.Forms.TextBox();
            this.txtMaTS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.butAdd = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(512, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Từ khóa";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(633, 34);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(265, 24);
            this.txtTuKhoa.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(713, 80);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbLoaiTS1
            // 
            this.cbbLoaiTS1.FormattingEnabled = true;
            this.cbbLoaiTS1.Location = new System.Drawing.Point(120, 76);
            this.cbbLoaiTS1.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiTS1.Name = "cbbLoaiTS1";
            this.cbbLoaiTS1.Size = new System.Drawing.Size(250, 26);
            this.cbbLoaiTS1.TabIndex = 4;
            // 
            // cbbNuocSX1
            // 
            this.cbbNuocSX1.FormattingEnabled = true;
            this.cbbNuocSX1.Location = new System.Drawing.Point(120, 28);
            this.cbbNuocSX1.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNuocSX1.Name = "cbbNuocSX1";
            this.cbbNuocSX1.Size = new System.Drawing.Size(250, 26);
            this.cbbNuocSX1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại tài sản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nước sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã tài sản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên tài sản";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Đơn vị tính";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 180);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.cbbLoaiTS);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.cbbNuocSX);
            this.tabPage1.Controls.Add(this.txtGhiChu);
            this.tabPage1.Controls.Add(this.butShow);
            this.tabPage1.Controls.Add(this.txtTskt);
            this.tabPage1.Controls.Add(this.txtDvTinh);
            this.tabPage1.Controls.Add(this.txtTenTS);
            this.tabPage1.Controls.Add(this.txtMaTS);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1021, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hiển thị và cập nhật";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbbLoaiTS
            // 
            this.cbbLoaiTS.FormattingEnabled = true;
            this.cbbLoaiTS.Location = new System.Drawing.Point(826, 8);
            this.cbbLoaiTS.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiTS.Name = "cbbLoaiTS";
            this.cbbLoaiTS.Size = new System.Drawing.Size(181, 24);
            this.cbbLoaiTS.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(501, 108);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // cbbNuocSX
            // 
            this.cbbNuocSX.FormattingEnabled = true;
            this.cbbNuocSX.Location = new System.Drawing.Point(501, 60);
            this.cbbNuocSX.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNuocSX.Name = "cbbNuocSX";
            this.cbbNuocSX.Size = new System.Drawing.Size(181, 24);
            this.cbbNuocSX.TabIndex = 5;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(826, 62);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(181, 22);
            this.txtGhiChu.TabIndex = 8;
            // 
            // butShow
            // 
            this.butShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butShow.Image = ((System.Drawing.Image)(resources.GetObject("butShow.Image")));
            this.butShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butShow.Location = new System.Drawing.Point(862, 100);
            this.butShow.Margin = new System.Windows.Forms.Padding(4);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(87, 32);
            this.butShow.TabIndex = 9;
            this.butShow.Text = "Hiển thị";
            this.butShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butShow.UseVisualStyleBackColor = false;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // txtTskt
            // 
            this.txtTskt.Location = new System.Drawing.Point(501, 10);
            this.txtTskt.Margin = new System.Windows.Forms.Padding(4);
            this.txtTskt.Name = "txtTskt";
            this.txtTskt.Size = new System.Drawing.Size(181, 22);
            this.txtTskt.TabIndex = 4;
            // 
            // txtDvTinh
            // 
            this.txtDvTinh.Location = new System.Drawing.Point(105, 113);
            this.txtDvTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDvTinh.Name = "txtDvTinh";
            this.txtDvTinh.Size = new System.Drawing.Size(210, 22);
            this.txtDvTinh.TabIndex = 3;
            // 
            // txtTenTS
            // 
            this.txtTenTS.Location = new System.Drawing.Point(105, 62);
            this.txtTenTS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTS.Name = "txtTenTS";
            this.txtTenTS.Size = new System.Drawing.Size(210, 22);
            this.txtTenTS.TabIndex = 2;
            // 
            // txtMaTS
            // 
            this.txtMaTS.Location = new System.Drawing.Point(105, 12);
            this.txtMaTS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTS.Name = "txtMaTS";
            this.txtMaTS.ReadOnly = true;
            this.txtMaTS.Size = new System.Drawing.Size(210, 22);
            this.txtMaTS.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(729, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ghi chú";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(729, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Loại tài sản";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(362, 113);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Năm sản xuất";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(364, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nước sản xuất";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(362, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Thông số kĩ thuật";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.txtTuKhoa);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1021, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbNuocSX1);
            this.groupBox1.Controls.Add(this.cbbLoaiTS1);
            this.groupBox1.Location = new System.Drawing.Point(103, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(399, 133);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter tìm kiếm";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 185);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1050, 242);
            this.dgv.TabIndex = 10;
            this.dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RowHeaderMouseClick);
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.butAdd.Image = ((System.Drawing.Image)(resources.GetObject("butAdd.Image")));
            this.butAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butAdd.Location = new System.Drawing.Point(317, 435);
            this.butAdd.Margin = new System.Windows.Forms.Padding(4);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(81, 32);
            this.butAdd.TabIndex = 11;
            this.butAdd.Text = "Thêm";
            this.butAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.butUpdate.Image = ((System.Drawing.Image)(resources.GetObject("butUpdate.Image")));
            this.butUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butUpdate.Location = new System.Drawing.Point(481, 435);
            this.butUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(96, 32);
            this.butUpdate.TabIndex = 12;
            this.butUpdate.Text = "Cập nhật";
            this.butUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butUpdate.UseVisualStyleBackColor = false;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(665, 435);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(64, 32);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Xóa";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 469);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cơ sở vật chất khoa CNTT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TSForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbLoaiTS1;
        private System.Windows.Forms.ComboBox cbbNuocSX1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtMaTS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbNuocSX;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTskt;
        private System.Windows.Forms.TextBox txtDvTinh;
        private System.Windows.Forms.TextBox txtTenTS;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.ComboBox cbbLoaiTS;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
