using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExperimentTreeViewV2.Classes;


namespace ExperimentTreeViewV2
{
    public partial class FormManageEmployee : Form
    {
        DataManager _dataManager;
        DataManager _roleDataManager;
        EmployeeTreeNode _selectedNode;
        FormAddEmployee fAddEmployee;

        private ContextMenuStrip _employeeMenu;
        ToolStripMenuItem _removeMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _addMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _updateMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _swapMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _editEmployeeItem = new ToolStripMenuItem();
        ToolStripMenuItem _editRoleItem = new ToolStripMenuItem();
        ToolStripMenuItem _addSecRoleItem = new ToolStripMenuItem();

        List<List<string>> _completeRoleTeamUUIDList;
        List<List<EmployeeTreeNode>> _completeTeamList;

        public FormManageEmployee()
        {
            InitializeComponent();
            _dataManager = new DataManager();
            _selectedNode = null;
            _roleDataManager = new DataManager();
            _completeRoleTeamUUIDList = new List<List<string>>();
            _completeTeamList = new List<List<EmployeeTreeNode>>();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _dataManager.SaveEmployeeData();
            MessageBox.Show("Data is added to file");
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            _dataManager.LoadEmployeeData();
            treeViewEmployee.Nodes.Clear();
            treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure);
            treeViewEmployee.ExpandAll();
        }
        private void FormManageEmployee_Load(object sender, EventArgs e)
        {
            _roleDataManager.LoadRoleData();
            _roleDataManager.RoleTreeStructure.ExtractCompleteTeam(_completeRoleTeamUUIDList);
            treeViewEmployee.Nodes.Clear();
            _dataManager.GenerateEmployeeRootNode();
            if (_dataManager.checkEmployeeFileExist())
            {
                _dataManager.LoadEmployeeData();
            }
            _dataManager.EmployeeTreeStructure.ExtractCompleteTeam(_completeRoleTeamUUIDList, _completeTeamList);
            //_dataManager.EmployeeTreeStructure.ResetAllProject();
            treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure); //label(display)
            treeViewEmployee.ExpandAll();
            InitializeMenuTreeView();
        }
        public void treeViewEmployee_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            _selectedNode = (EmployeeTreeNode)e.Node;
            if (_selectedNode != null)
            {
                if(_selectedNode.Employee.SecRole != null){
                    Debug.WriteLine(_selectedNode.Employee.SecRole.Name);
                }
                this.textboxUUID.Text = _selectedNode.Employee.UUID;
                this.textBoxEmployeeName.Text = _selectedNode.Employee.Name;
                if (_selectedNode.Employee.Name == "ROOT")
                {
                    this.textboxReportingOff.Text = "N.A.";
                }
                else
                {
                    this.textboxReportingOff.Text = _selectedNode.ParentEmployeeTreeNode.Employee.Name;
                }
                this.textBoxSalary.Text = _selectedNode.Employee.Salary.ToString();
                this.textBoxEmployeeRole.Text = _selectedNode.Employee.PriRole.Name;
                this.checkBoxDummy.Checked = _selectedNode.Employee.DummyStat;
                if (_selectedNode.Employee.Project == null)
                {
                    this.textBoxProject.Text = "No project";
                }
                else
                {
                    Debug.Write(_selectedNode.Employee.Project.Name);
                    this.textBoxProject.Text = _selectedNode.Employee.Project.Name;
                }


            }
            //Debug.Write(_selectedNode);
        }
        public void InitializeMenuTreeView()
        {
            _employeeMenu = new ContextMenuStrip();
            _removeMenuItem.Text = "Remove employee";
            _addMenuItem.Text = "Add employee";
            _updateMenuItem.Text = "Edit employee";
            _swapMenuItem.Text = "Swap employee";
            _editEmployeeItem.Text = "Edit employee details";
            _editRoleItem.Text = "Edit employee role";
            _addSecRoleItem.Text = "Add secondary role";

            _employeeMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
            _employeeMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            //Add the menu items to the menu.
            _employeeMenu.Items.AddRange(new ToolStripMenuItem[] { _removeMenuItem, _addMenuItem, _updateMenuItem, _swapMenuItem });
            _updateMenuItem.DropDownItems.AddRange(new ToolStripMenuItem[] { _editEmployeeItem, _editRoleItem, _addSecRoleItem });
            _updateMenuItem.DropDown.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
            //Set the ContextMenuStrip property to the ContextMenuStrip.
            this.treeViewEmployee.ContextMenuStrip = _employeeMenu;
            treeViewEmployee.NodeMouseClick += new TreeNodeMouseClickEventHandler(treeViewEmployee_NodeMouseClick);
        }

        public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            _employeeMenu.Close();
            ToolStripItem item = e.ClickedItem;
            _selectedNode = (EmployeeTreeNode)treeViewEmployee.SelectedNode;
            if ((item != null) && (_selectedNode != null))
            {
                if (item.Text == "Edit employee details")
                {
                    /**** A sample code which is frequently used to get a parent form work with a child form ****/
                    Employee employee = _selectedNode.Employee;
                    double parentSalary = _selectedNode.ParentEmployeeTreeNode.Employee.Salary;
                    string reportingOffName;
                    if (_selectedNode.Employee.Name == "ROOT")
                    {
                        reportingOffName = "N.A.";
                    }
                    else
                    {
                        reportingOffName = _selectedNode.ParentEmployeeTreeNode.Employee.Name;
                    }
                    //fur stands for form update role (ran out of naming ideas)
                    FormUpdateEmployee fur = new FormUpdateEmployee(parentSalary, employee.UUID, employee.Name, employee.Salary, reportingOffName, employee.PriRole, employee.SecRole, employee.DummyStat);
                    fur.comboBoxRoles.Enabled = false;
                    fur.Text = "Edit_Employee_Details";
                    fur.ModifyItemCallback = new FormUpdateEmployee.ModifyItemDelegate(this.ModifyItemCallbackFn);
                    fur.ShowDialog();
                }
                if (item.Text == "Add employee")
                {
                    List<RoleTreeNode> childRoleNodeForRoot = new List<RoleTreeNode>();
                    if (_selectedNode.Employee.PriRole.Name == "ROOT")
                    {
                        int i;
                        for(i=0; i < _roleDataManager.RoleTreeStructure.ChildRoleTreeNodes.Count; i++)
                        {
                            childRoleNodeForRoot.Add(_roleDataManager.RoleTreeStructure.ChildRoleTreeNodes[i]);
                        }
                    }
                    else
                    {
                        List<RoleTreeNode> resultRoleNode = new List<RoleTreeNode>();
                        _roleDataManager.RoleTreeStructure.SearchByName(_selectedNode.Employee.PriRole.Name, ref resultRoleNode);
                        Debug.WriteLine(resultRoleNode[0].Role.Name);
                        int i;
                        for (i = 0; i < resultRoleNode[0].ChildRoleTreeNodes.Count; i++)
                        {
                            childRoleNodeForRoot.Add(resultRoleNode[0].ChildRoleTreeNodes[i]);
                        }
                    }
                    fAddEmployee = new FormAddEmployee(_selectedNode, childRoleNodeForRoot);
                    fAddEmployee.ShowDialog();
                    if (fAddEmployee.NodeName != "" && fAddEmployee.NodeRoleName != "" && fAddEmployee.NodeSalary != -1 )
                    {
                        List<RoleTreeNode> resultRoleNode = new List<RoleTreeNode>();
                        _roleDataManager.RoleTreeStructure.SearchByName(fAddEmployee.NodeRoleName, ref resultRoleNode);

                        EmployeeTreeNode pNewNode = new EmployeeTreeNode(new Employee(fAddEmployee.NodeName, resultRoleNode[0].Role, fAddEmployee.NodeSalary, fAddEmployee.NodeDummyStat));
                        if (_selectedNode.Employee.Project != null)
                        {
                            pNewNode.Employee.Project = _selectedNode.Employee.Project;
                        }
                        if (!_selectedNode.ChildrenEmployeeNodes.Contains(pNewNode))
                        {
                            _selectedNode.AddChildrenEmployeeNode(pNewNode);
                            treeViewEmployee.ExpandAll();
                        }
                    }
                }
                if (item.Text == "Remove employee")
                {
                    if (_selectedNode.ChildrenEmployeeNodes.Count > 0)
                    {
                        var confirmResult = MessageBox.Show("The employee can only be removed if there are no subordinates, no assigned projects or if after removal will still remain a full team. Would you like to swap the employee with another first?"
                            , "Execute Employee Swap", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        if (confirmResult == DialogResult.OK)
                        {
                            _dataManager.SaveEmployeeData();
                            FormSwapEmployee fsf = new FormSwapEmployee(_selectedNode, _dataManager);
                            fsf.ShowDialog();
                            buttonLoad.PerformClick();
                        }
                    }
                    else
                    {
                        if (_selectedNode.Employee.Project == null)
                        {
                            var confirmResult = MessageBox.Show("Are you sure to delete this employee?",
                                        "Confirm Delete Employee",
                                        MessageBoxButtons.OKCancel);
                            if (confirmResult == DialogResult.OK)
                            {
                                if (_selectedNode.Employee.SecRole != null)
                                {
                                    List<EmployeeTreeNode> resultAnotherNode = new List<EmployeeTreeNode>();
                                    _dataManager.EmployeeTreeStructure.SearchRemainNodeByNodeName(_selectedNode.Employee.Name, _selectedNode.Employee.UUID, ref resultAnotherNode);
                                    resultAnotherNode[0].Employee.SecRole = null;
                                }
                                _dataManager.EmployeeTreeStructure.DeleteEmployeeNode(_selectedNode.Employee.UUID);
                                _dataManager.SaveEmployeeData();
                                buttonLoad.PerformClick();
                            }
                        }
                        else
                        {
                            List<string> remainRoleUUIDList = new List<string>();
                            remainRoleUUIDList.Add(_selectedNode.ParentEmployeeTreeNode.Employee.PriRole.UUID);
                            foreach (EmployeeTreeNode remainChildNode in _selectedNode.ParentEmployeeTreeNode.ChildrenEmployeeNodes)
                            {
                                if (remainChildNode.Employee.UUID != _selectedNode.Employee.UUID)
                                {
                                    remainRoleUUIDList.Add(remainChildNode.Employee.PriRole.UUID);
                                }
                            }
                            _roleDataManager.RoleTreeStructure.ExtractCompleteTeam(_completeRoleTeamUUIDList);
                            if(_selectedNode.QualifiedCompleteTeam(_completeRoleTeamUUIDList, remainRoleUUIDList))
                            {
                                var confirmResult = MessageBox.Show("Are you sure to delete this employee?",
                                        "Confirm Delete Employee",
                                        MessageBoxButtons.OKCancel);
                                if (confirmResult == DialogResult.OK)
                                {
                                    if (_selectedNode.Employee.SecRole != null)
                                    {
                                        List<EmployeeTreeNode> resultAnotherNode = new List<EmployeeTreeNode>();
                                        _dataManager.EmployeeTreeStructure.SearchRemainNodeByNodeName(_selectedNode.Employee.Name, _selectedNode.Employee.UUID, ref resultAnotherNode);
                                        resultAnotherNode[0].Employee.SecRole = null;
                                    }
                                    _dataManager.EmployeeTreeStructure.DeleteEmployeeNode(_selectedNode.Employee.UUID);
                                    _dataManager.SaveEmployeeData();
                                    buttonLoad.PerformClick();
                                }
                            }
                            else
                            {
                                MessageBox.Show("The employee can only be removed if there are no subordinates, no assigned projects or if after removal will still remain a full team!"
                            , "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                if (item.Text == "Swap employee")
                {
                    _dataManager.SaveEmployeeData();
                    FormSwapEmployee fsf = new FormSwapEmployee(_selectedNode, _dataManager);
                    fsf.ShowDialog();
                    buttonLoad.PerformClick();
                }
                if (item.Text == "Edit employee role")
                {
                    Employee employee = _selectedNode.Employee;
                    List<RoleTreeNode> resultRoleNode = new List<RoleTreeNode>(); //return parent role nodes
                    _roleDataManager.RoleTreeStructure.SearchByName(_selectedNode.Employee.PriRole.Name, ref resultRoleNode);
                    List<RoleTreeNode> roleNodesList = new List<RoleTreeNode>(); //list of chosen role nodes list

                    int i;
                    for (i = 0; i < resultRoleNode[0].ParentRoleTreeNode.ChildRoleTreeNodes.Count; i++)
                    {
                        roleNodesList.Add(resultRoleNode[0].ParentRoleTreeNode.ChildRoleTreeNodes[i]);
                    }
                    string reportingOffName;
                    if (_selectedNode.Employee.Name == "ROOT")
                    {
                        reportingOffName = "N.A.";
                    }
                    else
                    {
                        reportingOffName = _selectedNode.ParentEmployeeTreeNode.Employee.Name;
                    }
                    //fur stands for form update role (ran out of naming ideas)
                    FormUpdateEmployee fur = new FormUpdateEmployee(employee.UUID, employee.Name, employee.Salary, reportingOffName, employee.PriRole, employee.SecRole, roleNodesList, employee.DummyStat);
                    fur.ModifyItemCallback = new FormUpdateEmployee.ModifyItemDelegate(this.ModifyItemCallbackFn);
                    fur.ShowDialog();
                }
                if (item.Text == "Add secondary role")
                {
                    Employee employee = _selectedNode.Employee;
                    List<RoleTreeNode> resultRoleNode = new List<RoleTreeNode>(); //return parent role nodes
                    _roleDataManager.RoleTreeStructure.SearchByName(_selectedNode.Employee.PriRole.Name, ref resultRoleNode);

                    List<RoleTreeNode> roleNodesList = new List<RoleTreeNode>(); //list of chosen role nodes list
                    _roleDataManager.RoleTreeStructure.AllRolesAvailable(roleNodesList);
                    
                    string reportingOffName;
                    reportingOffName = _selectedNode.ParentEmployeeTreeNode.Employee.Name;

                    //fur stands for form update role (ran out of naming ideas)
                    FormAddSecondaryRole fasr = new FormAddSecondaryRole(employee.UUID, employee.Name, employee.Salary, reportingOffName, employee.PriRole, roleNodesList, _dataManager, _roleDataManager, employee.DummyStat);
                    fasr.AddSecRoleCallback = new FormAddSecondaryRole.AddSecRoleDelegate(this.AddSecRoleCallbackFn);
                    fasr.ShowDialog();
                }
            }
        }//end of contextMenu_ItemClicked

        private void ModifyItemCallbackFn(string uuid, string oriEmployeeName, string employeeName, double salary, string reportingOffName, Role priRole, Role secRole, bool dummyStat)
        {
            if (secRole != null)
            {
                List<EmployeeTreeNode> resultAnotherNode = new List<EmployeeTreeNode>();
                _dataManager.EmployeeTreeStructure.SearchRemainNodeByNodeName(oriEmployeeName, uuid, ref resultAnotherNode);
                resultAnotherNode[0].Employee.Name = employeeName;
                resultAnotherNode[0].Employee.Salary = salary;
                resultAnotherNode[0].Employee.PriRole = secRole;
                resultAnotherNode[0].Employee.SecRole = priRole;
                resultAnotherNode[0].Employee.DummyStat = dummyStat;
                resultAnotherNode[0].Text = employeeName + " - " + secRole.Name + ", " + priRole.Name  + " (S$" + salary + ")";
            }

            List<EmployeeTreeNode> resultNodes = new List<EmployeeTreeNode>();
            //Find the RoleTreeNode object which has the role object containing the matching
            //UUID value.
            _dataManager.EmployeeTreeStructure.SearchByUUID(uuid, ref resultNodes);
            //By right, there should only be one RoleTreeNode object found. Therefore,
            //I directly point to the first element inside the List to access the Role object's Name and Text property data.
            resultNodes[0].Employee.Name = employeeName;
            resultNodes[0].Employee.Salary = salary;
            resultNodes[0].Employee.PriRole = priRole;
            resultNodes[0].Employee.DummyStat = dummyStat;
            if (secRole != null)
            {
                resultNodes[0].Text = employeeName + " - " + priRole.Name + ", " + secRole.Name + " (S$" + salary + ")";
            }
            else
            {
                resultNodes[0].Text = employeeName + " - " + priRole.Name + " (S$" + salary + ")";
            }

        }//end of ModifyItemCallbackFn method
        private void AddSecRoleCallbackFn(string uuid, string employeeName, double salary, string reportingOffUUID, Role priRole, Role secRole, bool dummyStat)
        {
            List<EmployeeTreeNode> replicateNodes = new List<EmployeeTreeNode>();
            _dataManager.EmployeeTreeStructure.SearchByName(employeeName, ref replicateNodes);
            replicateNodes[0].Employee.SecRole = secRole;
            replicateNodes[0].Text = replicateNodes[0].Employee.Name + " - " + replicateNodes[0].Employee.PriRole.Name + ", " + replicateNodes[0].Employee.SecRole.Name + " (S$" + replicateNodes[0].Employee.Salary + ")";
            List<EmployeeTreeNode> resultParentNode = new List<EmployeeTreeNode>();
            //Find the RoleTreeNode object which has the role object containing the matching
            //UUID value.
            _dataManager.EmployeeTreeStructure.SearchByUUID(reportingOffUUID, ref resultParentNode);
            //By right, there should only be one RoleTreeNode object found. Therefore,
            EmployeeTreeNode pNewNode = new EmployeeTreeNode(new Employee(employeeName, secRole, priRole, salary, dummyStat));
            if (!resultParentNode[0].ChildrenEmployeeNodes.Contains(pNewNode))
            {
                resultParentNode[0].AddChildrenEmployeeNode(pNewNode);
                pNewNode.Text = pNewNode.Employee.Name + " - " + pNewNode.Employee.SecRole.Name + ", " + pNewNode.Employee.PriRole.Name + " (S$" + pNewNode.Employee.Salary + ")";
                treeViewEmployee.ExpandAll();
            }
        }//end of ModifyItemCallbackFn method

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            _selectedNode = (EmployeeTreeNode)treeViewEmployee.SelectedNode;
            //Enable all menu items first. Then disable the menu items which are not appropriate
            foreach (ToolStripMenuItem item in _employeeMenu.Items)
            {
                item.Enabled = true;
            }
            if (_selectedNode.Employee.PriRole.Name == "ROOT")
            {
                this._updateMenuItem.Enabled = false;
                this._removeMenuItem.Enabled = false;
                this._swapMenuItem.Enabled = false;
            }
            if (_selectedNode.Employee.PriRole.Name != "ROOT")
            {
                if (_selectedNode.ChildrenEmployeeNodes.Count > 0)
                {
                    this._updateMenuItem.Enabled = true;
                    //Should not allow the user to remove the RoleTreeNode object
                    //because there are child TreeNodes detected.
                    this._removeMenuItem.Enabled = true;
                    this._swapMenuItem.Enabled = true;
                }
            }
            if (_selectedNode.ParentEmployeeTreeNode.Employee.PriRole.ProjectLeader == true)
            {
                this._addMenuItem.Enabled = false;
            }
        }

        private void buttonExpandAll_Click(object sender, EventArgs e)
        {
            treeViewEmployee.ExpandAll();
        }

        private void buttonCollapseAll_Click(object sender, EventArgs e)
        {
            treeViewEmployee.CollapseAll();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _dataManager = new DataManager();
            _roleDataManager.LoadRoleData();
            _roleDataManager.RoleTreeStructure.ExtractCompleteTeam(_completeRoleTeamUUIDList);
            treeViewEmployee.Nodes.Clear();
            _dataManager.GenerateEmployeeRootNode();
            if (_dataManager.checkEmployeeFileExist())
            {
                _dataManager.LoadEmployeeData();
            }
            _dataManager.EmployeeTreeStructure.ExtractCompleteTeam(_completeRoleTeamUUIDList, _completeTeamList);
            treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure); //label(display)
            treeViewEmployee.ExpandAll();
            InitializeMenuTreeView();
        }
    }
}

