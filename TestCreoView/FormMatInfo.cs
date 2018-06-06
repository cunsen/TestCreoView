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
    public partial class FormMatInfo : ToolWindow
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
        public FormMatInfo()
        {
            InitializeComponent();
            ResetList();

            toolWindowName = "物料信息";
        }

        public void ResetList()
        {
            this.listView1.Items.Clear();
            ListViewItem item = this.listView1.Items.Add("人员编号");
            item.SubItems.Add("0123");
            item.SubItems.Add("工位编号");
            item.SubItems.Add("2018");

            item = this.listView1.Items.Add("人员姓名");
            item.SubItems.Add("张三");
            item.SubItems.Add("工位名称");
            item.SubItems.Add("装配");

            item = this.listView1.Items.Add("人员部门");
            item.SubItems.Add("总装");
            item.SubItems.Add("操作时间");
            item.SubItems.Add("2018/05/29 12:18");
        }

    }
}
