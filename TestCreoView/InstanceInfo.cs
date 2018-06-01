using System;
using System.Collections.Generic;
using System.Text;

namespace TestCreoView
{
    public struct InstanceInfo
    {
        public InstanceInfo(string _id, string _name, string _parent)
        {
            this.id = _id;
            this.name = _name;
            this.parent = _parent;
        }
        public string id;
        public string name;
        public string parent;
    }

    public class InstanceComp: Object
    {
        public InstanceComp(AxpviewLib.Axpview _view,InstanceInfo _instance)
        {
            this.mdlView = _view;
            this.instance = _instance;
        }
        private AxpviewLib.Axpview mdlView;
        private InstanceInfo instance;
        public Dictionary<string, InstanceComp> sonInstance = new Dictionary<string, InstanceComp>();

        public void HideComp()
        {
            mdlView.HideInstance(instance.id);
        }
        public bool IsRootMdl()
        {
            return instance.parent == ":";
        }
        public string GetName()
        {
            return instance.name;
        }
        public string GetParentID()
        {
            return instance.parent;
        }
        public string GetID()
        {
            return instance.id;
        }

       
    }

    public class InstanceMan
    {
        protected AxpviewLib.Axpview mdlView;
        public InstanceComp rootComp;
        public InstanceMan(AxpviewLib.Axpview _view)
        {
            this.mdlView = _view;
        }
        public Dictionary<string, InstanceComp> instanceArray = new Dictionary<string, InstanceComp>();

        public void BuildMdlTree() {

            foreach (KeyValuePair<string, InstanceComp> instance in instanceArray)
            {
                if(instance.Value.IsRootMdl())
                {
                    rootComp = instance.Value;
                }
                if (instanceArray.ContainsKey(instance.Value.GetParentID()))
                {
                    InstanceComp parent = instanceArray[instance.Value.GetParentID()];
                    parent.sonInstance.Add(instance.Key, instance.Value);
                }
            }
        }

        public void Clear()
        {
            instanceArray.Clear();
        }

        public void AddInstance(string _id,string _name,string _parent)
        {
            InstanceInfo instance = new InstanceInfo(_id, _name, _parent);
            InstanceComp instanceComp = new InstanceComp(this.mdlView, instance);
            instanceArray.Add(_id, instanceComp);
        }
        
    }


}
