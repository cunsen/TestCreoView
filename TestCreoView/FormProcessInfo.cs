using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace TestCreoView
{
    public partial class FormProcessInfo : ToolWindow
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
        public FormProcessInfo()
        {
            InitializeComponent();
            ResetList();
            toolWindowName = "工序工步";
        }

        protected void ResetList()
        {
            ListViewItem item = this.listView1.Items.Add("项目");
            item.SubItems.Add("");

            item = this.listView1.Items.Add("工序名称");
            item.SubItems.Add("");

            item = this.listView1.Items.Add("工种");
            item.SubItems.Add("");

            item = this.listView1.Items.Add("工序内容");
            item.SubItems.Add("");

        }
    }
}
