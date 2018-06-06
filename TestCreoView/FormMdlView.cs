using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AxpviewLib;
using WeifenLuo.WinFormsUI.Docking;


namespace TestCreoView
{
    public partial class FormMdlView : ToolWindow
    {
        public string toolWindowName
        {
            set
            {
                this.Text = value;
                this.TabText = value;
            }
            get { return this.TabText; }
        }
        protected InstanceMan instMan;

        public FormMdlView()
        {
            InitializeComponent();

            this.instMan = new InstanceMan(this.mdlView);
            this.mdlView.renderatstartup = "true";
            this.mdlView.thumbnailView = "true";
            toolWindowName = "子模型";
            this.mdlView.sourceUrl = @"..\..\pvz\test16_p_yceb.pvz";
        }

        protected void MyBeginInstance(object sender, EventArgs e)
        {
            instMan.Clear();
        }

        protected void MyInstalce(object sender, _DpviewEvents_OnInstanceEvent e)
        {
            if (e.id == null || e.id == ":")
            {
                return;
            }

            instMan.AddInstance(e.id, e.name, e.parent);
        }
        protected void MyEndInstalce(object sender, EventArgs e)
        {
            instMan.HideAllInstance();
        }

        protected void MyEndLoad(object sender, EventArgs e)
        {
            this.mdlView.ListInstances();
        }

        //鼠标移动掠过时响应
        protected void MyPreSelectInstance(object sender, _DpviewEvents_OnPreSelectedInstanceEvent e)
        {

        }

        protected void MyLaunchUrl(object sender, _DpviewEvents_OnLaunchUrlEvent e)
        {

        }
        protected void MyBeginSelect(object sender, EventArgs e)
        {

        }
        protected void MyEndSelect(object sender, EventArgs e)
        {

        }
        protected void MySelectInstance(object sender, _DpviewEvents_OnSelectInstanceEvent e)
        {

        }

        protected void InitializeMessage()
        {
            this.mdlView.OnBeginInstance += MyBeginInstance;
            this.mdlView.OnInstance += MyInstalce;
            this.mdlView.OnEndInstance += MyEndInstalce;
            this.mdlView.OnLoadComplete += MyEndLoad;
            this.mdlView.OnLaunchUrl += MyLaunchUrl;
            this.mdlView.OnPreSelectedInstance += MyPreSelectInstance;
            this.mdlView.OnBeginSelect += MyBeginSelect;
            this.mdlView.OnEndSelect += MyEndSelect;
            this.mdlView.OnSelectInstance += MySelectInstance;
            this.mdlView.OnMouseHover += MyMouseHover;
        }

        protected void MyMouseHover(object sender, _DpviewEvents_OnMouseHoverEvent e)
        {

        }




    }
}
