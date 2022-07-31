using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class EmployeeTreeNode : TreeNode, ISerializable
    {
        private EmployeeTreeNode _parentEmployeeTreeNode; // RoleTreeNode type object which describes the "Parent"
        private Employee _employee; // To hold the Role object which describes one role information
        //A collection of RoleTreeNode type objects which describes the "Children"
        private List<EmployeeTreeNode> _childrenEmployeeNodes;

        //Two constructors
        public EmployeeTreeNode(Employee employee)
        {
            _parentEmployeeTreeNode = null;
            _childrenEmployeeNodes = new List<EmployeeTreeNode>();
            _employee = employee;
            _employee.Container = this;
            if (employee.SecRole == null)
            {
                this.Text = employee.Name + " - " + employee.PriRole.Name + " (S$" + employee.Salary + ")";
            }
            else
            {
                this.Text = employee.Name + " - " + employee.PriRole.Name + ", " + employee.SecRole.Name + " (S$" + employee.Salary + ")";
            }

        } // end of constructor
        public EmployeeTreeNode()
        {

        } // End of constructor
          //End of two constructors

        public EmployeeTreeNode ParentEmployeeTreeNode
        {
            get { return _parentEmployeeTreeNode; }
            set { _parentEmployeeTreeNode = value; }
        }
        public Employee Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }
        public List<EmployeeTreeNode> ChildrenEmployeeNodes
        {
            get { return _childrenEmployeeNodes; }
            set { _childrenEmployeeNodes = value; }
        }
        public void SwappingNodes(EmployeeTreeNode _selectNode, EmployeeTreeNode _replacingNewNode)
        {
            if (this.ChildrenEmployeeNodes.Count > 0)
            {
                int i = 0;
                for (i = 0; i < this.ChildrenEmployeeNodes.Count; i++)
                {

                    if (this.ChildrenEmployeeNodes[i].Employee.UUID == _selectNode.Employee.UUID)
                    {
                        this.ChildrenEmployeeNodes[i] = _replacingNewNode;

                        Debug.WriteLine("swapped selected node" + this.ChildrenEmployeeNodes[i]);
                    }
                    else if (this.ChildrenEmployeeNodes[i].Employee.UUID == _replacingNewNode.Employee.UUID)
                    {
                        this.ChildrenEmployeeNodes[i] = _selectNode;
                        Debug.WriteLine("swapped replacing node" + this.ChildrenEmployeeNodes[i]);
                    }
                    this.ChildrenEmployeeNodes[i].ParentEmployeeTreeNode = this;
                    this.ChildrenEmployeeNodes[i].SwappingNodes(_selectNode, _replacingNewNode);
                }
            }
        }//End of RebuildTreeNodes
        public void RebuildTreeNodes()
        {
            this.Text = this.Employee.Name + " - " + this.Employee.PriRole.Name + " (S$" + this.Employee.Salary + ")";
            if (this.ChildrenEmployeeNodes.Count > 0)
            {
                int i = 0;
                for (i = 0; i < this.ChildrenEmployeeNodes.Count; i++)
                {
                    this.Nodes.Add(this.ChildrenEmployeeNodes[i]);
                    this.ChildrenEmployeeNodes[i].ParentEmployeeTreeNode = this;
                    this.ChildrenEmployeeNodes[i].RebuildTreeNodes();
                }
            }
        }//End of RebuildTreeNodes
        public void SaveToFileBinary(string filepath)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                Stream stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);

                bf.Serialize(stream, this);
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //End of SaveToFileBinary

        public EmployeeTreeNode ReadFromFileBinary(string filepath)
        {
            try
            {
                Stream stream = new FileStream(@filepath, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                EmployeeTreeNode root = null;
                if (stream.Length != 0)
                {
                    root = (EmployeeTreeNode)bf.Deserialize(stream);
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
            info.AddValue("Employee", _employee);
            info.AddValue("ChildrenEmployeeNodes", _childrenEmployeeNodes);
            info.AddValue("ParentEmployeeTreeNode", _parentEmployeeTreeNode);

        }//end of GetObjectData [ SERIALIZE ]
        // [DESERIALIZE]
        protected EmployeeTreeNode(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            this.Employee = (Employee)info.GetValue("Employee", typeof(Employee));
            this.Employee.Container = this;
            this.ChildrenEmployeeNodes = (List<EmployeeTreeNode>)info.GetValue("ChildrenEmployeeNodes", typeof(List<EmployeeTreeNode>));
            this.ParentEmployeeTreeNode = (EmployeeTreeNode)info.GetValue("ParentEmployeeTreeNode", typeof(EmployeeTreeNode));
        }//end of EmployeeTreeNode [ DESERIALIZE ]
        public void AddChildrenEmployeeNode(EmployeeTreeNode employeeNode)
        {
            employeeNode.ParentEmployeeTreeNode = this;
            _childrenEmployeeNodes.Add(employeeNode);
            this.Nodes.Add(employeeNode);
        } // End of AddChildrenEmployeeNode method
        public void DeleteEmployeeNode(string uuid)
        {
            if (this.ChildrenEmployeeNodes.Count > 0)
            {
                int i = 0;
                for (i = 0; i < this.ChildrenEmployeeNodes.Count; i++)
                {
                    if (this.ChildrenEmployeeNodes[i].Employee.UUID == uuid)
                    {
                        this.ChildrenEmployeeNodes.RemoveAt(i); //Recall that, ChildNodes is a List. It has built-in RemoveAt method
                        this.Nodes.RemoveAt(i);
                        return;
                    }
                    else
                    {
                        this.ChildrenEmployeeNodes[i].DeleteEmployeeNode(uuid);
                    }
                }
            }
        }
        public void SearchByUUID(string uuid, ref List<EmployeeTreeNode> foundNodes)
        {
            if (this.ChildrenEmployeeNodes.Count > 0)//Note: This if block may not be necessary at all. Though the logic works.
            {
                int i = 0;
                for (i = 0; i < this.ChildrenEmployeeNodes.Count; i++)
                {
                    if (this.ChildrenEmployeeNodes[i].Employee.UUID == uuid)
                    {  //Base case (Where the method code stops calling itself, 
                       //perform action and finally exit). This avoids infinite loop

                        foundNodes.Add(this.ChildrenEmployeeNodes[i]);
                    }
                    else
                    { //Recursive case (where the method calls itself)
                      //Each DepartmentNode type object has SearchDeleteById method
                        this.ChildrenEmployeeNodes[i].SearchByUUID(uuid, ref foundNodes);
                    }
                }
            }
        }//End of SearchByUUID method
        public void ExtractTakenRoleUUID(List<string> takenRoleUUIDList)
        {
            if (this.ChildrenEmployeeNodes.Count > 0)//Note: This if block may not be necessary at all. Though the logic works.
            {
                int i = 0;
                for (i = 0; i < this.ChildrenEmployeeNodes.Count; i++)
                {
                    if (this.ChildrenEmployeeNodes[i] != null)
                    {  //Base case (Where the method code stops calling itself, 
                       //perform action and finally exit). This avoids infinite loop
                       if (!takenRoleUUIDList.Contains(this.ChildrenEmployeeNodes[i].Employee.PriRole.Name))
                        {
                            takenRoleUUIDList.Add(this.ChildrenEmployeeNodes[i].Employee.PriRole.UUID);
                        }
                        this.ChildrenEmployeeNodes[i].ExtractTakenRoleUUID(takenRoleUUIDList);
                    }
                }
            }
        }
        public void ResetAllProject()
        {
            List<Project> _projectList = new List<Project>();
            if (this.ChildrenEmployeeNodes.Count > 0)//Note: This if block may not be necessary at all. Though the logic works.
            {
                int i = 0;
                for (i = 0; i < this.ChildrenEmployeeNodes.Count; i++)
                {
                    if (this.ChildrenEmployeeNodes[i] != null)
                    {  //Base case (Where the method code stops calling itself, 
                       //perform action and finally exit). This avoids infinite loop
                        this.ChildrenEmployeeNodes[i].Employee.ProjectList = _projectList; 
                        this.ChildrenEmployeeNodes[i].ResetAllProject();
                    }
                }
            }
        }
        public void ExtractCompleteTeam(List<List<string>> completeRoleTeamUUIDList, List<List<EmployeeTreeNode>> completeTeamsList)
        {
            if (this.ChildrenEmployeeNodes.Count > 0)//Note: This if block may not be necessary at all. Though the logic works.
            {
                int i = 0;
                for (i = 0; i < this.ChildrenEmployeeNodes.Count; i++)
                {
                    if (this.ChildrenEmployeeNodes[i].Employee.PriRole.ProjectLeader != true)
                    {
                        this.ChildrenEmployeeNodes[i].ExtractCompleteTeam(completeRoleTeamUUIDList, completeTeamsList);
                    }
                    else
                    {
                        foreach (List<string> oneCompleteRoleTeamUUID in completeRoleTeamUUIDList)
                        {
                            if (this.ChildrenEmployeeNodes[i].Employee.PriRole.UUID == oneCompleteRoleTeamUUID[0])
                            {
                                List<string> oneCompleteChildRoleTeamUUID = oneCompleteRoleTeamUUID.GetRange(1, oneCompleteRoleTeamUUID.Count -1);
                                List<string> childNodeUUIDList = new List<string>();
                                foreach(EmployeeTreeNode childNode in this.ChildrenEmployeeNodes[i].ChildrenEmployeeNodes)
                                {
                                    childNodeUUIDList.Add(childNode.Employee.PriRole.UUID);
                                }
                                bool qualifiedCompleteTeam = oneCompleteChildRoleTeamUUID.Intersect(childNodeUUIDList).Count() == oneCompleteChildRoleTeamUUID.Count();
                                if (qualifiedCompleteTeam)
                                {
                                    List<EmployeeTreeNode> oneCompleteTeam = new List<EmployeeTreeNode>();
                                    oneCompleteTeam.Add(this.ChildrenEmployeeNodes[i]); //projectLeaderNode
                                    foreach (EmployeeTreeNode childNode in this.ChildrenEmployeeNodes[i].ChildrenEmployeeNodes)
                                    {
                                        oneCompleteTeam.Add(childNode);
                                    }
                                    completeTeamsList.Add(oneCompleteTeam);
                                }
                            }
                        }
                    }
                }
            }
        }
        public void SearchByRoleUUID(string uuid, ref List<EmployeeTreeNode> foundNodes)
        {
            if (this.ChildrenEmployeeNodes.Count > 0)//Note: This if block may not be necessary at all. Though the logic works.
            {
                int i = 0;
                for (i = 0; i < this.ChildrenEmployeeNodes.Count; i++)
                {
                    if (this.ChildrenEmployeeNodes[i].Employee.PriRole.UUID == uuid)
                    {  //Base case (Where the method code stops calling itself, 
                       //perform action and finally exit). This avoids infinite loop

                        foundNodes.Add(this.ChildrenEmployeeNodes[i]);
                    }
                    else
                    { //Recursive case (where the method calls itself)
                      //Each DepartmentNode type object has SearchDeleteById method
                        this.ChildrenEmployeeNodes[i].SearchByRoleUUID(uuid, ref foundNodes);
                    }
                }
            }
        }//End of SearchEmployeeNameByRoleUUID method
        public void SearchByName(string name, ref List<EmployeeTreeNode> foundNodes)
        {
            if (this.ChildrenEmployeeNodes.Count > 0)//Note: This if block may not be necessary at all. Though the logic works.
            {
                int i = 0;
                for (i = 0; i < this.ChildrenEmployeeNodes.Count; i++)
                {
                    if (this.ChildrenEmployeeNodes[i].Employee.Name == name)
                    {  //Base case (Where the method code stops calling itself, 
                       //perform action and finally exit). This avoids infinite loop

                        foundNodes.Add(this.ChildrenEmployeeNodes[i]);
                    }
                    else
                    { //Recursive case (where the method calls itself)
                      //Each DepartmentNode type object has SearchDeleteById method
                        this.ChildrenEmployeeNodes[i].SearchByName(name, ref foundNodes);
                    }
                }
            }
        }//End of SearchByUUID method
    }
}
