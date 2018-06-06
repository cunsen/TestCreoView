using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using System;


namespace TestCreoView
{
    public partial class MainForm : Form
    {
        private bool m_bSaveLayout = true;
        private DeserializeDockContent m_deserializeDockContent;
        private readonly ToolStripRenderer _toolStripProfessionalRenderer = new ToolStripProfessionalRenderer();

        //窗体相关
        private DocTotalMdl m_docTotal;
        private FormListEquipment m_formList;
        private FormMdlTree m_formTree;
        private FormMdlView m_formView;
        private FormAsmInfo m_formPic;
        private FormProcessInfo m_formProcess;
        private FormUserInfo m_formUserInfo;
        private FormListAuxiMat m_formAuxiMat;
        private FormMatInfo m_formMatInfo;

        public MainForm()
        {
            InitializePropertyWnd();
            InitializeComponent();

            AutoScaleMode = AutoScaleMode.Dpi;
            dockPanel.DocumentStyle = DocumentStyle.DockingSdi;

            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
            vsToolStripExtender1.DefaultRenderer = _toolStripProfessionalRenderer;
            SetSchema(this.menuItemSchemaVS2013Blue, null);
            ShowTotalMdlDoc();
        }

        protected void InitializePropertyWnd()
        {
            m_docTotal = new DocTotalMdl();
            m_formList = new FormListEquipment();
            m_formTree = new FormMdlTree();
            m_formView = new FormMdlView();
            m_formPic = new FormAsmInfo();
            m_formProcess = new FormProcessInfo();
            m_formUserInfo = new FormUserInfo();
            m_formAuxiMat = new FormListAuxiMat();
            m_formMatInfo = new FormMatInfo();
        }

        protected void ShowTotalMdlDoc()
        {
            if (m_docTotal != null && !m_docTotal.IsDisposed)
            {
                return;
            }
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                m_docTotal.MdiParent = this;
                m_docTotal.Show();
            }
            else
                m_docTotal.Show(dockPanel);
        }

        private void CloseAllContents()
        {
            //         
            m_formList.DockPanel = null;
            m_formTree.DockPanel = null;
            m_formView.DockPanel = null;
            m_formPic.DockPanel = null;
            m_formAuxiMat.DockPanel = null;

            m_formProcess.DockPanel = null;
            m_formUserInfo.DockPanel = null;
            m_formMatInfo.DockPanel = null;

            foreach (var window in dockPanel.FloatWindows.ToList())
                window.Dispose();
            // m_docTotal.DockHandler.DockPanel = null;
            //m_docTotal.DockHandler.Close();


            System.Diagnostics.Debug.Assert(dockPanel.Panes.Count == 0);
            System.Diagnostics.Debug.Assert(dockPanel.Contents.Count == 0);
            System.Diagnostics.Debug.Assert(dockPanel.FloatWindows.Count == 0);
        }

        private void CloseAllDocuments()
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    form.Close();
            }
            else
            {
                foreach (IDockContent document in dockPanel.DocumentsToArray())
                {
                    // IMPORANT: dispose all panes.
                    document.DockHandler.DockPanel = null;
                    document.DockHandler.Close();
                }
            }
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(FormListEquipment).ToString())
                return m_formList;
            else if (persistString == typeof(FormMdlTree).ToString())
                return m_formTree;
            else if (persistString == typeof(FormMdlView).ToString())
                return m_formView;
            else if (persistString == typeof(FormAsmInfo).ToString())
                return m_formPic;
            else if (persistString == typeof(FormProcessInfo).ToString())
                return m_formProcess;
            else if (persistString == typeof(FormUserInfo).ToString())
                return m_formUserInfo;
            else if (persistString == typeof(DocTotalMdl).ToString())
                return m_docTotal;
            else if (persistString == typeof(FormListAuxiMat).ToString())
                return m_formAuxiMat;
            else if (persistString == typeof(FormMatInfo).ToString())
                return m_formMatInfo;

            else
            {
                // DummyDoc overrides GetPersistString to add extra information into persistString.
                // Any DockContent may override this value to add any needed information for deserialization.

                string[] parsedStrings = persistString.Split(new char[] { ',' });
                if (parsedStrings.Length != 3)
                    return null;

                if (parsedStrings[0] != typeof(DocTotalMdl).ToString())
                    return null;

                //DocTotalMdl dummyDoc = new DocTotalMdl();
                //if (parsedStrings[1] != string.Empty)
                //    dummyDoc.FileName = parsedStrings[1];
                //if (parsedStrings[2] != string.Empty)
                //    dummyDoc.Text = parsedStrings[2];

                //return dummyDoc;

                return null;
            }
        }


        private void SetSchema(object sender, System.EventArgs e)
        {
            // Persist settings when rebuilding UI
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.temp.config");

            dockPanel.SaveAsXml(configFile);
            CloseAllContents();

            if (sender == this.menuItemSchemaVS2012Light)
            {
                this.dockPanel.Theme = this.vS2012LightTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2012, vS2012LightTheme1);
            }
            else if (sender == this.menuItemSchemaVS2012Blue)
            {
                this.dockPanel.Theme = this.vS2012BlueTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2012, vS2012BlueTheme1);
            }
            else if (sender == this.menuItemSchemaVS2012Dark)
            {
                this.dockPanel.Theme = this.vS2012DarkTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2012, vS2012DarkTheme1);
            }
            else if (sender == this.menuItemSchemaVS2013Blue)
            {
                this.dockPanel.Theme = this.vS2013BlueTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2013, vS2013BlueTheme1);
            }
            else if (sender == this.menuItemSchemaVS2013Light)
            {
                this.dockPanel.Theme = this.vS2013LightTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2013, vS2013LightTheme1);
            }
            else if (sender == this.menuItemSchemaVS2013Dark)
            {
                this.dockPanel.Theme = this.vS2013DarkTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2013, vS2013DarkTheme1);
            }
            else if (sender == this.menuItemSchemaVS2015Blue)
            {
                this.dockPanel.Theme = this.vS2015BlueTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, vS2015BlueTheme1);
            }
            else if (sender == this.menuItemSchemaVS2015Light)
            {
                this.dockPanel.Theme = this.vS2015LightTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, vS2015LightTheme1);
            }
            else if (sender == this.menuItemSchemaVS2015Dark)
            {
                this.dockPanel.Theme = this.vS2015DarkTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, vS2015DarkTheme1);
            }

            menuItemSchemaVS2012Light.Checked = (sender == menuItemSchemaVS2012Light);
            menuItemSchemaVS2012Blue.Checked = (sender == menuItemSchemaVS2012Blue);
            menuItemSchemaVS2012Dark.Checked = (sender == menuItemSchemaVS2012Dark);
            menuItemSchemaVS2013Light.Checked = (sender == menuItemSchemaVS2013Light);
            menuItemSchemaVS2013Blue.Checked = (sender == menuItemSchemaVS2013Blue);
            menuItemSchemaVS2013Dark.Checked = (sender == menuItemSchemaVS2013Dark);
            menuItemSchemaVS2015Light.Checked = (sender == menuItemSchemaVS2015Light);
            menuItemSchemaVS2015Blue.Checked = (sender == menuItemSchemaVS2015Blue);
            menuItemSchemaVS2015Dark.Checked = (sender == menuItemSchemaVS2015Dark);
            if (dockPanel.Theme.ColorPalette != null)
            {
                statusBar.BackColor = dockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background;
            }

            if (File.Exists(configFile))
                dockPanel.LoadFromXml(configFile, m_deserializeDockContent);
        }

        private void EnableVSRenderer(VisualStudioToolStripExtender.VsVersion version, ThemeBase theme)
        {
            vsToolStripExtender1.SetStyle(mainMenu, version, theme);
            vsToolStripExtender1.SetStyle(toolBar, version, theme);
            vsToolStripExtender1.SetStyle(statusBar, version, theme);
        }

        private void menuItemToolBar_Click(object sender, System.EventArgs e)
        {
            toolBar.Visible = menuItemToolBar.Checked = !menuItemToolBar.Checked;

        }

        private void menuItemStatusBar_Click(object sender, System.EventArgs e)
        {
            statusBar.Visible = menuItemStatusBar.Checked = !menuItemStatusBar.Checked;
        }

        private void menuItemLockLayout_Click(object sender, System.EventArgs e)
        {
            dockPanel.AllowEndUserDocking = !dockPanel.AllowEndUserDocking;
        }

        #region 弹出下拉菜单
        private void menuItemViews_Popup(object sender, System.EventArgs e)
        {
            mdlTreeToolStripMenuItem.Checked = IsFormActive(m_formTree);
            gongYiToolStripMenuItem.Checked = IsFormActive(m_formProcess);
            asmInfoToolStripMenuItem.Checked = IsFormActive(m_formPic);
            mdlViewToolStripMenuItem.Checked = IsFormActive(m_formView);

            userInfoToolStripMenuItem.Checked = IsFormActive(m_formUserInfo);
            auxiMatToolStripMenuItem.Checked = IsFormActive(m_formAuxiMat);
            matInfoToolStripMenuItem.Checked = IsFormActive(m_formMatInfo);
            toolListToolStripMenuItem.Checked = IsFormActive(m_formList);

        }

        private void menuItemTools_Popup(object sender, System.EventArgs e)
        {
            menuItemLockLayout.Checked = !this.dockPanel.AllowEndUserDocking;
        }
        private bool IsFormActive(ToolWindow form)
        {
            if (form == null || form.IsDisposed)
                return false;
            return !form.IsHidden;
        }

        #endregion

        #region 控件布局文件的读写
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");

            if (File.Exists(configFile))
                dockPanel.LoadFromXml(configFile, m_deserializeDockContent);
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
            if (m_bSaveLayout)
                dockPanel.SaveAsXml(configFile);
            else if (File.Exists(configFile))
                File.Delete(configFile);
        }
        #endregion


        private void mdlViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_formView.IsDisposed)
                m_formView = new FormMdlView();
            m_formView.Show(this.dockPanel);
        }

        private void totalMdlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                m_docTotal.MdiParent = this;
                m_docTotal.Show();
            }
            else
                m_docTotal.Show(dockPanel);
        }



        #region 相关属性视图显示
        private void mdlTreeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (m_formTree.IsDisposed)
                m_formTree = new FormMdlTree();
            m_formTree.Show(this.dockPanel);
        }

        private void pictureToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (m_formPic == null || m_formPic.IsDisposed)
            {
                m_formPic = new FormAsmInfo();
            }
            m_formPic.Show(this.dockPanel);
        }

        private void userInfoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (m_formUserInfo.IsDisposed)
                m_formUserInfo = new FormUserInfo();
            m_formUserInfo.Show(this.dockPanel);
        }

        private void gongYiToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (m_formProcess.IsDisposed)
                m_formProcess = new FormProcessInfo();
            m_formProcess.Show(this.dockPanel);
        }
        private void toolListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_formList == null || m_formList.IsDisposed)
                m_formList = new FormListEquipment();
            m_formList.Show(this.dockPanel);
        }

        private void auxiMatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_formAuxiMat == null || m_formAuxiMat.IsDisposed)
                m_formAuxiMat = new FormListAuxiMat();
            m_formAuxiMat.Show(this.dockPanel);
        }

        private void matInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_formMatInfo == null || m_formMatInfo.IsDisposed)
                m_formMatInfo = new FormMatInfo();
            m_formMatInfo.Show(this.dockPanel);
        }
        #endregion

    }
}
