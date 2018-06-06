namespace TestCreoView
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
            this.components = new System.ComponentModel.Container();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuItemViews = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mdlTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asmInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gongYiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mdlViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLockLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSchemaVS2015Light = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2015Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2015Dark = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2013Light = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2013Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2013Dark = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2012Light = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2012Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2012Dark = new System.Windows.Forms.ToolStripMenuItem();
            this.vS2015BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme();
            this.vS2015DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();
            this.vS2015LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            this.vS2013BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2013BlueTheme();
            this.vS2013DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2013DarkTheme();
            this.vS2013LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2013LightTheme();
            this.vS2012BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2012BlueTheme();
            this.vS2012DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2012DarkTheme();
            this.vS2012LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2012LightTheme();
            this.vsToolStripExtender1 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.auxiMatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dockPanel.DockBottomPortion = 150D;
            this.dockPanel.DockLeftPortion = 200D;
            this.dockPanel.DockRightPortion = 200D;
            this.dockPanel.DockTopPortion = 150D;
            this.dockPanel.Location = new System.Drawing.Point(0, 50);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.RightToLeftLayout = true;
            this.dockPanel.Size = new System.Drawing.Size(800, 378);
            this.dockPanel.TabIndex = 0;
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.Black;
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 4;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemViews,
            this.menuItemTools});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 25);
            this.mainMenu.TabIndex = 6;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuItemViews
            // 
            this.menuItemViews.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemToolBar,
            this.menuItemStatusBar,
            this.toolStripSeparator1,
            this.mdlTreeToolStripMenuItem,
            this.auxiMatToolStripMenuItem,
            this.toolListToolStripMenuItem,
            this.asmInfoToolStripMenuItem,
            this.userInfoToolStripMenuItem,
            this.matInfoToolStripMenuItem,
            this.gongYiToolStripMenuItem,
            this.mdlViewToolStripMenuItem});
            this.menuItemViews.Name = "menuItemViews";
            this.menuItemViews.Size = new System.Drawing.Size(44, 21);
            this.menuItemViews.Text = "&视图";
            this.menuItemViews.DropDownOpening += new System.EventHandler(this.menuItemViews_Popup);
            // 
            // menuItemToolBar
            // 
            this.menuItemToolBar.Checked = true;
            this.menuItemToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemToolBar.Name = "menuItemToolBar";
            this.menuItemToolBar.Size = new System.Drawing.Size(180, 22);
            this.menuItemToolBar.Text = "Tool Bar";
            this.menuItemToolBar.Click += new System.EventHandler(this.menuItemToolBar_Click);
            // 
            // menuItemStatusBar
            // 
            this.menuItemStatusBar.Checked = true;
            this.menuItemStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemStatusBar.Name = "menuItemStatusBar";
            this.menuItemStatusBar.Size = new System.Drawing.Size(180, 22);
            this.menuItemStatusBar.Text = "Status Bar";
            this.menuItemStatusBar.Click += new System.EventHandler(this.menuItemStatusBar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mdlTreeToolStripMenuItem
            // 
            this.mdlTreeToolStripMenuItem.Name = "mdlTreeToolStripMenuItem";
            this.mdlTreeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mdlTreeToolStripMenuItem.Text = "模型树";
            this.mdlTreeToolStripMenuItem.Click += new System.EventHandler(this.mdlTreeToolStripMenuItem_Click);
            // 
            // asmInfoToolStripMenuItem
            // 
            this.asmInfoToolStripMenuItem.Name = "asmInfoToolStripMenuItem";
            this.asmInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asmInfoToolStripMenuItem.Text = "安装信息";
            this.asmInfoToolStripMenuItem.Click += new System.EventHandler(this.pictureToolStripMenuItem_Click);
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userInfoToolStripMenuItem.Text = "操作信息";
            this.userInfoToolStripMenuItem.Click += new System.EventHandler(this.userInfoToolStripMenuItem_Click);
            // 
            // gongYiToolStripMenuItem
            // 
            this.gongYiToolStripMenuItem.Name = "gongYiToolStripMenuItem";
            this.gongYiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gongYiToolStripMenuItem.Text = "工序工步";
            this.gongYiToolStripMenuItem.Click += new System.EventHandler(this.gongYiToolStripMenuItem_Click);
            // 
            // mdlViewToolStripMenuItem
            // 
            this.mdlViewToolStripMenuItem.Name = "mdlViewToolStripMenuItem";
            this.mdlViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mdlViewToolStripMenuItem.Text = "子模型";
            this.mdlViewToolStripMenuItem.Click += new System.EventHandler(this.mdlViewToolStripMenuItem_Click);
            // 
            // toolListToolStripMenuItem
            // 
            this.toolListToolStripMenuItem.Name = "toolListToolStripMenuItem";
            this.toolListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolListToolStripMenuItem.Text = "工具工装清单";
            this.toolListToolStripMenuItem.Click += new System.EventHandler(this.toolListToolStripMenuItem_Click);
            // 
            // menuItemTools
            // 
            this.menuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLockLayout,
            this.menuItem1,
            this.menuItemSchemaVS2015Light,
            this.menuItemSchemaVS2015Blue,
            this.menuItemSchemaVS2015Dark,
            this.menuItemSchemaVS2013Light,
            this.menuItemSchemaVS2013Blue,
            this.menuItemSchemaVS2013Dark,
            this.menuItemSchemaVS2012Light,
            this.menuItemSchemaVS2012Blue,
            this.menuItemSchemaVS2012Dark});
            this.menuItemTools.Name = "menuItemTools";
            this.menuItemTools.Size = new System.Drawing.Size(44, 21);
            this.menuItemTools.Text = "&风格";
            this.menuItemTools.DropDownOpening += new System.EventHandler(this.menuItemTools_Popup);
            // 
            // menuItemLockLayout
            // 
            this.menuItemLockLayout.Checked = true;
            this.menuItemLockLayout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemLockLayout.Name = "menuItemLockLayout";
            this.menuItemLockLayout.Size = new System.Drawing.Size(203, 22);
            this.menuItemLockLayout.Text = "Lock Layout";
            this.menuItemLockLayout.Click += new System.EventHandler(this.menuItemLockLayout_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // menuItemSchemaVS2015Light
            // 
            this.menuItemSchemaVS2015Light.Name = "menuItemSchemaVS2015Light";
            this.menuItemSchemaVS2015Light.Size = new System.Drawing.Size(203, 22);
            this.menuItemSchemaVS2015Light.Text = "Schema: VS2015 Light";
            this.menuItemSchemaVS2015Light.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2015Blue
            // 
            this.menuItemSchemaVS2015Blue.Name = "menuItemSchemaVS2015Blue";
            this.menuItemSchemaVS2015Blue.Size = new System.Drawing.Size(203, 22);
            this.menuItemSchemaVS2015Blue.Text = "Schema: VS2015 Blue";
            this.menuItemSchemaVS2015Blue.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2015Dark
            // 
            this.menuItemSchemaVS2015Dark.Name = "menuItemSchemaVS2015Dark";
            this.menuItemSchemaVS2015Dark.Size = new System.Drawing.Size(203, 22);
            this.menuItemSchemaVS2015Dark.Text = "Schema: VS2015 Dark";
            this.menuItemSchemaVS2015Dark.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2013Light
            // 
            this.menuItemSchemaVS2013Light.Name = "menuItemSchemaVS2013Light";
            this.menuItemSchemaVS2013Light.Size = new System.Drawing.Size(203, 22);
            this.menuItemSchemaVS2013Light.Text = "Schema: VS2013 Light";
            this.menuItemSchemaVS2013Light.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2013Blue
            // 
            this.menuItemSchemaVS2013Blue.Name = "menuItemSchemaVS2013Blue";
            this.menuItemSchemaVS2013Blue.Size = new System.Drawing.Size(203, 22);
            this.menuItemSchemaVS2013Blue.Text = "Schema: VS2013 Blue";
            this.menuItemSchemaVS2013Blue.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2013Dark
            // 
            this.menuItemSchemaVS2013Dark.Name = "menuItemSchemaVS2013Dark";
            this.menuItemSchemaVS2013Dark.Size = new System.Drawing.Size(203, 22);
            this.menuItemSchemaVS2013Dark.Text = "Schema: VS2013 Dark";
            this.menuItemSchemaVS2013Dark.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2012Light
            // 
            this.menuItemSchemaVS2012Light.Name = "menuItemSchemaVS2012Light";
            this.menuItemSchemaVS2012Light.Size = new System.Drawing.Size(203, 22);
            this.menuItemSchemaVS2012Light.Text = "Schema: VS2012 Light";
            this.menuItemSchemaVS2012Light.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2012Blue
            // 
            this.menuItemSchemaVS2012Blue.Name = "menuItemSchemaVS2012Blue";
            this.menuItemSchemaVS2012Blue.Size = new System.Drawing.Size(203, 22);
            this.menuItemSchemaVS2012Blue.Text = "Schema: VS2012 Blue";
            this.menuItemSchemaVS2012Blue.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2012Dark
            // 
            this.menuItemSchemaVS2012Dark.Name = "menuItemSchemaVS2012Dark";
            this.menuItemSchemaVS2012Dark.Size = new System.Drawing.Size(203, 22);
            this.menuItemSchemaVS2012Dark.Text = "Schema: VS2012 Dark";
            this.menuItemSchemaVS2012Dark.Click += new System.EventHandler(this.SetSchema);
            // 
            // vsToolStripExtender1
            // 
            this.vsToolStripExtender1.DefaultRenderer = null;
            // 
            // toolBar
            // 
            this.toolBar.Location = new System.Drawing.Point(0, 25);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(800, 25);
            this.toolBar.TabIndex = 8;
            this.toolBar.Text = "toolStrip1";
            // 
            // auxiMatToolStripMenuItem
            // 
            this.auxiMatToolStripMenuItem.Name = "auxiMatToolStripMenuItem";
            this.auxiMatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.auxiMatToolStripMenuItem.Text = "辅助材料清单";
            this.auxiMatToolStripMenuItem.Click += new System.EventHandler(this.auxiMatToolStripMenuItem_Click);
            // 
            // matInfoToolStripMenuItem
            // 
            this.matInfoToolStripMenuItem.Name = "matInfoToolStripMenuItem";
            this.matInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.matInfoToolStripMenuItem.Text = "物料信息";
            this.matInfoToolStripMenuItem.Click += new System.EventHandler(this.matInfoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemTools;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2015Light;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2015Blue;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2015Dark;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2013Light;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2013Blue;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2013Dark;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2012Light;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2012Blue;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2012Dark;
        private WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme vS2015BlueTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme vS2015DarkTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vS2015LightTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2013BlueTheme vS2013BlueTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2013DarkTheme vS2013DarkTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2013LightTheme vS2013LightTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2012BlueTheme vS2012BlueTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2012DarkTheme vS2012DarkTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2012LightTheme vS2012LightTheme1;
        private System.Windows.Forms.ToolStripMenuItem menuItemLockLayout;
        private WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender vsToolStripExtender1;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripSeparator menuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemViews;
        private System.Windows.Forms.ToolStripMenuItem menuItemToolBar;
        private System.Windows.Forms.ToolStripMenuItem menuItemStatusBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mdlTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asmInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gongYiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mdlViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auxiMatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matInfoToolStripMenuItem;
    }
}