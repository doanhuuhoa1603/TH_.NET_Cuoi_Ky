﻿namespace TH_NET_Cuoi_Ky.GUI
{
    partial class NuocSXForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuocSXForm));
            this.but_Delete = new System.Windows.Forms.Button();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.but_Update = new System.Windows.Forms.Button();
            this.but_Search = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtTenNSX = new System.Windows.Forms.TextBox();
            this.txtMaNSX = new System.Windows.Forms.TextBox();
            this.but_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.but_Show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Delete
            // 
            this.but_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.but_Delete.Image = ((System.Drawing.Image)(resources.GetObject("but_Delete.Image")));
            this.but_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Delete.Location = new System.Drawing.Point(461, 464);
            this.but_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.but_Delete.Name = "but_Delete";
            this.but_Delete.Size = new System.Drawing.Size(71, 32);
            this.but_Delete.TabIndex = 43;
            this.but_Delete.Text = "Xóa";
            this.but_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Delete.UseVisualStyleBackColor = false;
            this.but_Delete.Click += new System.EventHandler(this.but_Delete_Click);
            // 
            // but_Cancel
            // 
            this.but_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.but_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("but_Cancel.Image")));
            this.but_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Cancel.Location = new System.Drawing.Point(577, 464);
            this.but_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(80, 32);
            this.but_Cancel.TabIndex = 40;
            this.but_Cancel.Text = "Thoát";
            this.but_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Cancel.UseVisualStyleBackColor = false;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(104, 43);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(210, 24);
            this.txt_Search.TabIndex = 39;
            // 
            // but_Update
            // 
            this.but_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_Update.Image = ((System.Drawing.Image)(resources.GetObject("but_Update.Image")));
            this.but_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Update.Location = new System.Drawing.Point(321, 464);
            this.but_Update.Margin = new System.Windows.Forms.Padding(4);
            this.but_Update.Name = "but_Update";
            this.but_Update.Size = new System.Drawing.Size(101, 32);
            this.but_Update.TabIndex = 38;
            this.but_Update.Text = "Cập nhật";
            this.but_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Update.UseVisualStyleBackColor = false;
            this.but_Update.Click += new System.EventHandler(this.but_Update_Click);
            // 
            // but_Search
            // 
            this.but_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.but_Search.Image = ((System.Drawing.Image)(resources.GetObject("but_Search.Image")));
            this.but_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Search.Location = new System.Drawing.Point(125, 89);
            this.but_Search.Margin = new System.Windows.Forms.Padding(4);
            this.but_Search.Name = "but_Search";
            this.but_Search.Size = new System.Drawing.Size(105, 32);
            this.but_Search.TabIndex = 37;
            this.but_Search.Text = "Tìm kiếm";
            this.but_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Search.UseVisualStyleBackColor = false;
            this.but_Search.Click += new System.EventHandler(this.but_Search_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(23, 163);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(681, 293);
            this.dgv.TabIndex = 36;
            this.dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RowHeaderMouseClick);
            // 
            // txtTenNSX
            // 
            this.txtTenNSX.Location = new System.Drawing.Point(112, 93);
            this.txtTenNSX.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNSX.Name = "txtTenNSX";
            this.txtTenNSX.Size = new System.Drawing.Size(208, 24);
            this.txtTenNSX.TabIndex = 31;
            // 
            // txtMaNSX
            // 
            this.txtMaNSX.Location = new System.Drawing.Point(112, 36);
            this.txtMaNSX.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNSX.Name = "txtMaNSX";
            this.txtMaNSX.ReadOnly = true;
            this.txtMaNSX.Size = new System.Drawing.Size(208, 24);
            this.txtMaNSX.TabIndex = 30;
            // 
            // but_Add
            // 
            this.but_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.but_Add.Image = ((System.Drawing.Image)(resources.GetObject("but_Add.Image")));
            this.but_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Add.Location = new System.Drawing.Point(187, 464);
            this.but_Add.Margin = new System.Windows.Forms.Padding(4);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(83, 32);
            this.but_Add.TabIndex = 29;
            this.but_Add.Text = "Thêm";
            this.but_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Add.UseVisualStyleBackColor = false;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã NSX";
            // 
            // but_Show
            // 
            this.but_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.but_Show.Image = ((System.Drawing.Image)(resources.GetObject("but_Show.Image")));
            this.but_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Show.Location = new System.Drawing.Point(51, 464);
            this.but_Show.Margin = new System.Windows.Forms.Padding(4);
            this.but_Show.Name = "but_Show";
            this.but_Show.Size = new System.Drawing.Size(93, 32);
            this.but_Show.TabIndex = 24;
            this.but_Show.Text = "Hiển thị";
            this.but_Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Show.UseVisualStyleBackColor = false;
            this.but_Show.Click += new System.EventHandler(this.but_Show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên Nước";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaNSX);
            this.groupBox1.Controls.Add(this.txtTenNSX);
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(346, 138);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.but_Search);
            this.groupBox2.Controls.Add(this.txt_Search);
            this.groupBox2.Location = new System.Drawing.Point(375, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(324, 138);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Từ khóa";
            // 
            // NuocSXForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(717, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_Delete);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.but_Update);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.but_Show);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NuocSXForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Nước Sản Xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuocSXForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_Delete;
        private System.Windows.Forms.Button but_Cancel;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button but_Update;
        private System.Windows.Forms.Button but_Search;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtTenNSX;
        private System.Windows.Forms.TextBox txtMaNSX;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_Show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}