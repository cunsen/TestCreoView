namespace TestCreoView
{
    partial class FormMdlView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMdlView));
            this.mdlView = new AxpviewLib.Axpview();
            ((System.ComponentModel.ISupportInitialize)(this.mdlView)).BeginInit();
            this.SuspendLayout();
            // 
            // mdlView
            // 
            this.mdlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdlView.Enabled = true;
            this.mdlView.Location = new System.Drawing.Point(0, 0);
            this.mdlView.Name = "mdlView";
            this.mdlView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mdlView.OcxState")));
            this.mdlView.Size = new System.Drawing.Size(523, 428);
            this.mdlView.TabIndex = 0;
            // 
            // FormMdlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 428);
            this.Controls.Add(this.mdlView);
            this.Name = "FormMdlView";
            this.Text = "FormMdlView";
            ((System.ComponentModel.ISupportInitialize)(this.mdlView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxpviewLib.Axpview mdlView;
    }
}