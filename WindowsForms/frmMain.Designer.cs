﻿namespace WindowsForms
{
    partial class frmMain
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
            this.panMainForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panMainForm
            // 
            this.panMainForm.BackColor = System.Drawing.Color.White;
            this.panMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMainForm.Location = new System.Drawing.Point(0, 0);
            this.panMainForm.Name = "panMainForm";
            this.panMainForm.Size = new System.Drawing.Size(1001, 553);
            this.panMainForm.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 553);
            this.Controls.Add(this.panMainForm);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panMainForm;
    }
}