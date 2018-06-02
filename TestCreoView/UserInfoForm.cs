using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestCreoView
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
            ResetList();
        }

        public void ResetList()
        {
            for(int i = 0;i < 10;i++)
            {
                this.listView1.Items.Add(i.ToString());

            }
        }

    }
}
