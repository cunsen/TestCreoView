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
    public partial class FormAsmInfo : ToolWindow
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
        public FormAsmInfo()
        {
            InitializeComponent();
            InitializePic();
            toolWindowName = "安装信息";
        }

        protected void InitializePic()
        {
            this.pictureBox1.Load(@"..\..\image\GB5786-A.jpg");
        }
    }
}
