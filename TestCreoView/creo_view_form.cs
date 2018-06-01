using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AxpviewLib;

namespace TestCreoView
{
    public partial class creo_view_form : Form
    {
        protected InstanceMan instMan;
        protected Bitmap bitmap;
        protected ImageList imageList = new ImageList();
        public creo_view_form()
        {
            InitializeComponent();
            InitializeMessage();
            InitializeImageList();
            this.mdlTree.ImageList = imageList;

            this.mdlView.renderatstartup = "true";
            this.mdlView.thumbnailView = "true";
            this.instMan = new InstanceMan(this.mdlView);
            this.mdlView.sourceUrl = @"..\..\pvz\test16_p_yceb.pvz";
        }

        private void BtnTestClick(object sender, EventArgs e)
        {
            this.mdlView.ListInstances();
        }

        protected void MyBeginInstance(object sender, EventArgs e)
        {
            instMan.Clear();
        }

        protected void MyInstalce(object sender, _DpviewEvents_OnInstanceEvent e)
        {
            if(e.id == null || e.id == ":")
            {
                return;
            }
            instMan.AddInstance(e.id,e.name,e.parent);
        }
        protected void MyEndInstalce(object sender, EventArgs e)
        {
            instMan.BuildMdlTree();
            UpdateTreeInfo();
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
            this.mdlView.OnPreSelectedInstance+= MyPreSelectInstance;
            this.mdlView.OnBeginSelect += MyBeginSelect;
            this.mdlView.OnEndSelect += MyEndSelect;
            this.mdlView.OnSelectInstance += MySelectInstance;
        }


        protected void UpdateTreeInfo()
        {
            this.mdlTree.Nodes.Clear();
         
            TreeNode node = this.mdlTree.Nodes.Add(instMan.rootComp.GetName());
            node.Tag = instMan.rootComp;
            node.ImageIndex = GetImageIndex(instMan.rootComp);
            node.SelectedImageIndex = node.ImageIndex;

            UpdateTreeNode(node,instMan.rootComp);
            node.ExpandAll();
        }
        protected void InitializeImageList()
        {
            bitmap = new Bitmap(@"..\..\image\bitmap_tree.bmp");
            imageList.Images.Clear();
            int _length = 0;
            for(; _length < bitmap.Width; _length+=16)
            {
                Bitmap _bitMap = bitmap.Clone(new Rectangle(_length, 0, 16, 16), System.Drawing.Imaging.PixelFormat.DontCare);
                imageList.Images.Add(Image.FromHbitmap(_bitMap.GetHbitmap()));
            }

        }
        protected void UpdateTreeNode(TreeNode _node,InstanceComp _inst)
        {
            foreach(KeyValuePair<string, InstanceComp> _instance in _inst.sonInstance)
            {
                TreeNode sonNode = _node.Nodes.Add(_instance.Value.GetName());
                sonNode.Tag = _instance.Value;
                 sonNode.ImageIndex = GetImageIndex(_instance.Value);
                sonNode.SelectedImageIndex = sonNode.ImageIndex;
 //               sonNode.ImageIndex = nidx_t++;
                if (_instance.Value.sonInstance.Count > 0)
                {
                    UpdateTreeNode(sonNode,_instance.Value);
                }
            }
        }

        int GetImageIndex(InstanceComp _instance)
        {
            string _name = _instance.GetName();
            if(_name.Contains(".PRT"))
            {
                return 1;
            }
            else if(_name.Contains(".ASM"))
            {
                return 0;
            }
            return 8;
        }
    }
}
