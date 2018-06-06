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
    public partial class FormListAuxiMat : ToolWindow
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
        public FormListAuxiMat()
        {
            InitializeComponent();
            toolWindowName = "辅助材料清单";
        }
    }
}
