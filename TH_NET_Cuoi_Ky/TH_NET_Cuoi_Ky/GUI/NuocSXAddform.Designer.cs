﻿namespace TH_NET_Cuoi_Ky.GUI
{
    partial class NuocSXAddform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuocSXAddform));
            this.txtTenNSX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTenNSX
            // 
            this.txtTenNSX.Location = new System.Drawing.Point(94, 18);
            this.txtTenNSX.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNSX.Name = "txtTenNSX";
            this.txtTenNSX.Size = new System.Drawing.Size(221, 24);
            this.txtTenNSX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tên Nước";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Image = global::TH_NET_Cuoi_Ky.Properties.Resources.butOK_Image;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(94, 62);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "OK";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(223, 62);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NuocSXAddform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(328, 112);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTenNSX);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NuocSXAddform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nước mới";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NuocSXAddform_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NuocSXAddform_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNSX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}