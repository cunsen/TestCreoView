using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestCreoView
{
    public partial class FormUserInfo : Form
    {
        public FormUserInfo()
        {
            InitializeComponent();
            ResetList();
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
