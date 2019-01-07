﻿namespace TH_NET_Cuoi_Ky.GUI
{
    partial class Import_ExportTSForm
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 45);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(329, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(130, 84);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(92, 32);
            this.btn.TabIndex = 1;
            this.btn.Text = "Hủy";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 17);
            this.label.TabIndex = 2;
            this.label.Text = "Trạng thái";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            this.saveFileDialog.Filter = "Tất cả các tệp|*.*|MS Excel (2007-2019)|*.xlsx|MS Excel (2003)|*.xls";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xlsx";
            this.openFileDialog.Filter = "MS Excel (2007-2019)|*.xlsx|MS Excel (2003)|*.xls";
            // 
            // exportWorker
            // 
            this.exportWorker.WorkerReportsProgress = true;
            this.exportWorker.WorkerSupportsCancellation = true;
            this.exportWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.exportWorker_DoWork);
            this.exportWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.exportWorker_ProgressChanged);
            this.exportWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.exportWorker_RunWorkerCompleted);
            // 
            // Import_ExportTSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 126);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.progressBar1);
            this.Name = "Import_ExportTSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExportTSForm";
            this.Shown += new System.EventHandler(this.Import_ExportTSForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker exportWorker;
    }
}