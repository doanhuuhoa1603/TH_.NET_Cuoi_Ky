﻿namespace TH_NET_Cuoi_Ky.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.btnNuocSX = new System.Windows.Forms.Button();
            this.btnNhaCC = new System.Windows.Forms.Button();
            this.btnNhapXuat = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnNguoiQL = new System.Windows.Forms.Button();
            this.btnLoaiTS = new System.Windows.Forms.Button();
            this.btnTS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.btnNuocSX);
            this.groupBox1.Controls.Add(this.btnNhaCC);
            this.groupBox1.Controls.Add(this.btnNhapXuat);
            this.groupBox1.Controls.Add(this.btnPhong);
            this.groupBox1.Controls.Add(this.btnNguoiQL);
            this.groupBox1.Controls.Add(this.btnLoaiTS);
            this.groupBox1.Controls.Add(this.btnTS);
            this.groupBox1.Location = new System.Drawing.Point(4, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(909, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lựa chọn";
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.butCancel.Image = ((System.Drawing.Image)(resources.GetObject("butCancel.Image")));
            this.butCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCancel.Location = new System.Drawing.Point(728, 143);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(112, 32);
            this.butCancel.TabIndex = 14;
            this.butCancel.Text = "Thoát";
            this.butCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butCancel.UseVisualStyleBackColor = false;
            // 
            // btnNuocSX
            // 
            this.btnNuocSX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNuocSX.Location = new System.Drawing.Point(482, 143);
            this.btnNuocSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuocSX.Name = "btnNuocSX";
            this.btnNuocSX.Size = new System.Drawing.Size(141, 32);
            this.btnNuocSX.TabIndex = 13;
            this.btnNuocSX.Text = "Nước Sản Xuất";
            this.btnNuocSX.UseVisualStyleBackColor = false;
            this.btnNuocSX.Click += new System.EventHandler(this.btnNuocSX_Click);
            // 
            // btnNhaCC
            // 
            this.btnNhaCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNhaCC.Location = new System.Drawing.Point(270, 143);
            this.btnNhaCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhaCC.Name = "btnNhaCC";
            this.btnNhaCC.Size = new System.Drawing.Size(132, 32);
            this.btnNhaCC.TabIndex = 12;
            this.btnNhaCC.Text = "Nhà Cung Cấp";
            this.btnNhaCC.UseVisualStyleBackColor = false;
            this.btnNhaCC.Click += new System.EventHandler(this.btnNhaCC_Click);
            // 
            // btnNhapXuat
            // 
            this.btnNhapXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNhapXuat.Location = new System.Drawing.Point(51, 143);
            this.btnNhapXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhapXuat.Name = "btnNhapXuat";
            this.btnNhapXuat.Size = new System.Drawing.Size(112, 32);
            this.btnNhapXuat.TabIndex = 11;
            this.btnNhapXuat.Text = "Nhập Xuất";
            this.btnNhapXuat.UseVisualStyleBackColor = false;
            this.btnNhapXuat.Click += new System.EventHandler(this.btnNhapXuat_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPhong.Location = new System.Drawing.Point(728, 60);
            this.btnPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(112, 32);
            this.btnPhong.TabIndex = 10;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnNguoiQL
            // 
            this.btnNguoiQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNguoiQL.Location = new System.Drawing.Point(482, 60);
            this.btnNguoiQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNguoiQL.Name = "btnNguoiQL";
            this.btnNguoiQL.Size = new System.Drawing.Size(141, 32);
            this.btnNguoiQL.TabIndex = 9;
            this.btnNguoiQL.Text = "Người Quản Lý";
            this.btnNguoiQL.UseVisualStyleBackColor = false;
            this.btnNguoiQL.Click += new System.EventHandler(this.btnNguoiQL_Click);
            // 
            // btnLoaiTS
            // 
            this.btnLoaiTS.BackColor = System.Drawing.Color.Silver;
            this.btnLoaiTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLoaiTS.Location = new System.Drawing.Point(270, 60);
            this.btnLoaiTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoaiTS.Name = "btnLoaiTS";
            this.btnLoaiTS.Size = new System.Drawing.Size(112, 32);
            this.btnLoaiTS.TabIndex = 8;
            this.btnLoaiTS.Text = "Loại Tài Sản";
            this.btnLoaiTS.UseVisualStyleBackColor = false;
            this.btnLoaiTS.Click += new System.EventHandler(this.btnLoaiTS_Click);
            // 
            // btnTS
            // 
            this.btnTS.BackColor = System.Drawing.Color.Coral;
            this.btnTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTS.Location = new System.Drawing.Point(51, 60);
            this.btnTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(112, 32);
            this.btnTS.TabIndex = 7;
            this.btnTS.Text = "Tài Sản";
            this.btnTS.UseVisualStyleBackColor = false;
            this.btnTS.Click += new System.EventHandler(this.btnTS_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 267);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cơ sở vật chất khoa Công nghệ thông tin";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button btnNuocSX;
        private System.Windows.Forms.Button btnNhaCC;
        private System.Windows.Forms.Button btnNhapXuat;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnNguoiQL;
        private System.Windows.Forms.Button btnLoaiTS;
        private System.Windows.Forms.Button btnTS;
    }
}