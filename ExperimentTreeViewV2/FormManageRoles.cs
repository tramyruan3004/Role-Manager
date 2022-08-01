using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using ExperimentTreeViewV2.Classes;

namespace ExperimentTreeViewV2
{
    public partial class FormManageRoles : Form
    {
        DataManager _dataManager;
        RoleTreeNode _selectedNode;
        FormAddRole fAddRole;
        DataManager _employeeDataManager;
        List<string> _takenRoleUUIDList;

        private ContextMenuStrip _roleMenu;
        ToolStripMenuItem _removeMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _addMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _updateMenuItem = new ToolStripMenuItem();

        public FormManageRoles()
        {
            InitializeComponent();
            _dataManager = new DataManager();
            _employeeDataManager = new DataManager();
            _selectedNode = null;
            _takenRoleUUIDList = new List<string>();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _dataManager.SaveRoleData();
            MessageBox.Show("Data is added to file");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            _dataManager.LoadRoleData();
            treeViewRole.Nodes.Clear();
            treeViewRole.Nodes.Add(_dataManager.RoleTreeStructure);
            treeViewRole.ExpandAll();
        }
        private void FormManageRoles_Load(object sender, EventArgs e)
        {
            _employeeDataManager.LoadEmployeeData();
            _employeeDataManager.EmployeeTreeStructure.ExtractTakenRoleUUID(_takenRoleUUIDList);
            treeViewRole.Nodes.Clear();
            _dataManager.GenerateRootNode();
            if (_dataManager.checkRoleFileExist())
            {
                _dataManager.LoadRoleData();
            }
            _dataManager.RoleTreeStructure.TakenRoles(_takenRoleUUIDList);
            treeViewRole.Nodes.Add(_dataManager.RoleTreeStructure); //label(display)
            treeViewRole.ExpandAll();
            InitializeMenuTreeView();
        }
        public void treeViewRole_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Debug.WriteLine(e.Node);
            _selectedNode = (RoleTreeNode)e.Node;
            if (_selectedNode != null)
            {
                this.textboxUUID.Text = _selectedNode.Role.UUID;
                this.textboxRoleName.Text = _selectedNode.Role.Name;
                this.checkBoxProjectLeader.Checked = _selectedNode.Role.ProjectLeader;
            }
            //Debug.Write(_selectedNode);
        }
        public void InitializeMenuTreeView()
        {
            _roleMenu = new ContextMenuStrip();
            _removeMenuItem.Text = "Remove role";
            _addMenuItem.Text = "Add child role";
            _updateMenuItem.Text = "Edit role";

            _roleMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
            _roleMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            //Add the menu items to the menu.
            _roleMenu.Items.AddRange(new ToolStripMenuItem[] { _removeMenuItem, _addMenuItem, _updateMenuItem });
            //Set the ContextMenuStrip property to the ContextMenuStrip.
            this.treeViewRole.ContextMenuStrip = _roleMenu;
            treeViewRole.NodeMouseClick += new TreeNodeMouseClickEventHandler(treeViewRole_NodeMouseClick);
        }

        public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            _roleMenu.Close();
            ToolStripItem item = e.ClickedItem;
            _selectedNode = (RoleTreeNode)treeViewRole.SelectedNode;
            if ((item != null) && (_selectedNode != null))
            {
                if (item.Text == "Edit role")
                {   /**** A sample code which is frequently used to get a parent form work with a child form ****/
                    Role role = _selectedNode.Role;
                    string parentName = _selectedNode.ParentRoleTreeNode.Role.Name;
                    bool projectLeaderStat = _selectedNode.Role.ProjectLeader;
                    //check if qualified for projLeader
                    bool qualifiedProjLead = _selectedNode.QualifiedProjLeader();
                    //fur stands for form update role (ran out of naming ideas)
                    FormUpdateRole fur = new FormUpdateRole(role.UUID, role.Name, parentName, projectLeaderStat, qualifiedProjLead);
                    fur.ModifyItemCallback = new FormUpdateRole.ModifyItemDelegate(this.ModifyItemCallbackFn);
                    fur.ShowDialog();
                }
                if (item.Text == "Add child role")
                {
                    string parentName = _selectedNode.Role.Name;
                    fAddRole = new FormAddRole(_selectedNode);
                    fAddRole.ShowDialog();
                    if (fAddRole.NodeName != "")
                    {
                        RoleTreeNode pNewNode = new RoleTreeNode(new Role(fAddRole.NodeName));
                        if (!_selectedNode.ChildRoleTreeNodes.Contains(pNewNode))
                        {
                            _selectedNode.AddChildRoleTreeNode(pNewNode);
                            treeViewRole.ExpandAll();
                        }
                    }
                }
                if (item.Text == "Remove role")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this role?",
                                     "Confirm Delete Role",
                                     MessageBoxButtons.OKCancel);
                    if (confirmResult == DialogResult.OK)
                    {
                        _dataManager.RoleTreeStructure.DeleteRoleNode(_selectedNode.Role.UUID);
                        textboxConsole.Text = "yes";
                    }
                    else
                    {
                        textboxConsole.Text = "no";
                    }
                }
            }

        }//end of contextMenu_ItemClicked
        private void ModifyItemCallbackFn(string uuid, string roleName, bool projectLeaderStat)
        {
            List<RoleTreeNode> resultNodes = new List<RoleTreeNode>();
            //Find the RoleTreeNode object which has the role object containing the matching
            //UUID value.
            _dataManager.RoleTreeStructure.SearchByUUID(uuid, ref resultNodes);
            //By right, there should only be one RoleTreeNode object found. Therefore,
            //I directly point to the first element inside the List to access the Role object's Name and Text property data.
            resultNodes[0].Role.Name = roleName;
            resultNodes[0].Text = roleName;
            resultNodes[0].Role.ProjectLeader = projectLeaderStat;
        }//end of ModifyItemCallbackFn method

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            _selectedNode = (RoleTreeNode)treeViewRole.SelectedNode;
            //Enable all menu items first. Then disable the menu items which are not appropriate
            foreach (ToolStripMenuItem item in _roleMenu.Items)
            {
                item.Enabled = true;
            }
            if (_selectedNode.Text == "ROOT")
            {
                this._updateMenuItem.Enabled = false;
                this._removeMenuItem.Enabled = false;
            }
            if (_selectedNode.Text != "ROOT")
            {
                if (_selectedNode.ChildRoleTreeNodes.Count > 0)
                {
                    this._updateMenuItem.Enabled = true;
                    //Should not allow the user to remove the RoleTreeNode object
                    //because there are child TreeNodes detected.
                    this._removeMenuItem.Enabled = true;
                }
            }
            if (_selectedNode.Role.TakenRole == true)
            {
                this._removeMenuItem.Enabled = false;
            }
            if (_selectedNode.ParentRoleTreeNode.Role.ProjectLeader == true)
            {
                this._addMenuItem.Enabled = false;
            }

        }
        
        private void buttonExpandAll_Click(object sender, EventArgs e)
        {
            treeViewRole.ExpandAll();
        }

        private void buttonCollapseAll_Click(object sender, EventArgs e)
        {
            treeViewRole.CollapseAll();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _dataManager = new DataManager();
            treeViewRole.Nodes.Clear();
            _dataManager.GenerateRootNode();
            if (_dataManager.checkRoleFileExist())
            {
                _dataManager.LoadRoleData();
            }
            treeViewRole.Nodes.Add(_dataManager.RoleTreeStructure); //label(display)
            treeViewRole.ExpandAll();
            InitializeMenuTreeView();
        }
    }
}
