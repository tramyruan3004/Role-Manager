using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
//System.Windows.Forms namespace must be included so that TreeNode class
//can be recognized by the .NET engine.
using System.Windows.Forms; 

namespace ExperimentTreeViewV2.Classes
{
    [Serializable]
    public class RoleTreeNode:TreeNode, ISerializable
    {
        private RoleTreeNode _parentRoleTreeNode; // RoleTreeNode type object which describes the "Parent"
        private Role _role; // To hold the Role object which describes one role information
        //A collection of RoleTreeNode type objects which describes the "Children"
        private List<RoleTreeNode> _children;

        //Two constructors
        public RoleTreeNode(Role role)
        {
            _parentRoleTreeNode = null;
            _children = new List<RoleTreeNode>();
            _role = role;
            _role.Container = this;
            this.Text = role.Name;
        } // end of constructor
        public RoleTreeNode()
        {

        } // End of constructor
        //End of two constructors



        public RoleTreeNode ParentRoleTreeNode
        {
            get { return _parentRoleTreeNode; }
            set { _parentRoleTreeNode = value; }
        }

        public Role Role { 
            get { return _role; } 
            set { _role = value; }
        }
        public List<RoleTreeNode> ChildRoleTreeNodes {
            get { return _children; } 
            set { _children = value; } 
        }


        public void AddChildRoleTreeNode(RoleTreeNode roleNode)
        {
            roleNode.ParentRoleTreeNode = this;
            _children.Add(roleNode);
            this.Nodes.Add(roleNode);
        } // End of AddChildRoleTreeNode method

        /* When you work on File IO operations, TreeNode class is [not serializable]                      */
        /* As a result the following three methods were defined to support the                              */
        /* reconstruction of all the TreeNode objects within each RoleTreeNode type objects     */
        /* Each developer usually has their own technique to reconstruct the TreeNode objects*/
        public void RebuildTreeNodes()
        {
            this.Text = this.Role.Name;
            if (this.ChildRoleTreeNodes.Count > 0)
            {
                int i = 0;
                for (i = 0; i < this.ChildRoleTreeNodes.Count; i++)
                {
                    this.Nodes.Add(this.ChildRoleTreeNodes[i]);
                    this.ChildRoleTreeNodes[i].ParentRoleTreeNode = this;
                    this.ChildRoleTreeNodes[i].RebuildTreeNodes();
                }
            }

        }//End of RebuildTreeNodes
        // File IO Functions ----------------------------------------------------------------------------------------------

        public void SaveToFileBinary(string filepath)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                Stream stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);

                bf.Serialize(stream, this);
                stream.Close();

                MessageBox.Show("Data is added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //End of SaveToFileBinary

        public RoleTreeNode ReadFromFileBinary(string filepath)
        {
            try
            {
                Stream stream = new FileStream(@filepath, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                RoleTreeNode root = null;
                if (stream.Length != 0)
                {
                    root = (RoleTreeNode)bf.Deserialize(stream);
                }
                stream.Close();

                return root;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Unable to find file.");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }//end of ReadFromFileBinary

        // [ SERIALIZE ]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //add the required data to file
            info.AddValue("Role", _role);
            info.AddValue("ChildrenRoleTreeNodes", _children);
            info.AddValue("ParentRoleTreeNode", _parentRoleTreeNode);

        }//end of GetObjectData [ SERIALIZE ]
        // [DESERIALIZE]
        protected RoleTreeNode(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            this.Role = (Role)info.GetValue("Role", typeof(Role));
            this.Role.Container = this;
            this.ChildRoleTreeNodes = (List<RoleTreeNode>)info.GetValue("ChildrenRoleTreeNodes", typeof(List<RoleTreeNode>));
            this.ParentRoleTreeNode = (RoleTreeNode)info.GetValue("ParentRoleTreeNode", typeof(RoleTreeNode));
        }//end of RoleTreeNode [ DESERIALIZE ]

        // End Of File IO Functions ---------------------------------------------------------------------------------------

        public void SearchByUUID(string uuid, ref List<RoleTreeNode> foundNodes)
        {
            if (this.ChildRoleTreeNodes.Count > 0)//Note: This if block may not be necessary at all. Though the logic works.
            {
                int i = 0;
                for (i = 0; i < this.ChildRoleTreeNodes.Count; i++)
                {
                    if (this.ChildRoleTreeNodes[i].Role.UUID == uuid)
                    {  //Base case (Where the method code stops calling itself, 
                       //perform action and finally exit). This avoids infinite loop

                        foundNodes.Add(this.ChildRoleTreeNodes[i]);
                    }
                    else
                    { //Recursive case (where the method calls itself)
                      //Each DepartmentNode type object has SearchDeleteById method
                        this.ChildRoleTreeNodes[i].SearchByUUID(uuid, ref foundNodes);
                    }
                }
            }
        }//End of SearchByUUID method
    }//end of RoleTreeNode class
}//end of namespace
