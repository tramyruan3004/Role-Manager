using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ExperimentTreeViewV2.Classes
{
    [Serializable]
    internal class Role
    {
        private string _uuid; // Role UUID
        private string _name; // Role Name
        private RoleTreeNode _container; // References the RoleTreeNode object that contains the role
        //two constructors
        public Role()
        {
        }//end of constructor
        public Role(string name)
        {
            _uuid = General.GenerateUUID();
            _name = name;
        } // end of constructor
        //end of two constructors
        public RoleTreeNode Container
        {
            get { return _container; }
            set { _container = value; }
        }
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        } // End of UUID property

        public string Name
        {
            get { return _name; }
            set { _name = value;
  
            }
        } // End of Name property

        public void EditRole(string name)
        {
            _name = name;
        }// End of EditRole method
    }//end of Role class
}//end of namespace
