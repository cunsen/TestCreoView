﻿namespace TestCreoView
{
    partial class DocTotalMdl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocTotalMdl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mdlView = new AxpviewLib.Axpview();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdlView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mdlView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // mdlView
            // 
            this.mdlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdlView.Enabled = true;
            this.mdlView.Location = new System.Drawing.Point(0, 0);
            this.mdlView.Name = "mdlView";
            this.mdlView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mdlView.OcxState")));
            this.mdlView.Size = new System.Drawing.Size(800, 450);
            this.mdlView.TabIndex = 0;
            // 
            // DocTotalMdl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "DocTotalMdl";
            this.Text = "DocTotalMdl";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mdlView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxpviewLib.Axpview mdlView;
    }
}