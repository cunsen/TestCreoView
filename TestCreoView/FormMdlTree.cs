using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace TestCreoView
{
    public partial class FormMdlTree : ToolWindow
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
        public FormMdlTree()
        {
            InitializeComponent();
            toolWindowName = "模型树";
        }
    }
}
