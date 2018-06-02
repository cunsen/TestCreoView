namespace TestCreoView
{
    partial class creo_view_form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(creo_view_form));
            this.mdlView = new AxpviewLib.Axpview();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.mdlTree = new System.Windows.Forms.TreeView();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图片显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mdlView)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdlView
            // 
            this.mdlView.CausesValidation = false;
            this.mdlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdlView.Enabled = true;
            this.mdlView.Location = new System.Drawing.Point(0, 0);
            this.mdlView.Name = "mdlView";
            this.mdlView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mdlView.OcxState")));
            this.mdlView.Size = new System.Drawing.Size(1221, 655);
            this.mdlView.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBottom.Controls.Add(this.splitter1);
            this.panelBottom.Controls.Add(this.panelLeft);
            this.panelBottom.Controls.Add(this.panelRight);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 131);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1221, 655);
            this.panelBottom.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(249, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 655);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.mdlTree);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(249, 655);
            this.panelLeft.TabIndex = 0;
            // 
            // mdlTree
            // 
            this.mdlTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdlTree.Location = new System.Drawing.Point(0, 0);
            this.mdlTree.Name = "mdlTree";
            this.mdlTree.Size = new System.Drawing.Size(249, 655);
            this.mdlTree.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.mdlView);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1221, 655);
            this.panelRight.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.menuStrip1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1221, 131);
            this.panelTop.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.窗口ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1221, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图片显示ToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // 图片显示ToolStripMenuItem
            // 
            this.图片显示ToolStripMenuItem.Name = "图片显示ToolStripMenuItem";
            this.图片显示ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.图片显示ToolStripMenuItem.Text = "图片显示";
            this.图片显示ToolStripMenuItem.Click += new System.EventHandler(this.MenuShowPicDlg);
            // 
            // creo_view_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 786);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "creo_view_form";
            this.Text = "模型预览对话框";
            ((System.ComponentModel.ISupportInitialize)(this.mdlView)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxpviewLib.Axpview mdlView;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TreeView mdlTree;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图片显示ToolStripMenuItem;
    }
}

