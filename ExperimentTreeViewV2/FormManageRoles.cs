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

        private ContextMenuStrip _roleMenu;
        ToolStripMenuItem _removeMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _addMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _updateMenuItem = new ToolStripMenuItem();

        public FormManageRoles()
        {
            InitializeComponent();
            _dataManager = new DataManager();
            _selectedNode = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

        }
        private void FormManageRoles_Load(object sender, EventArgs e)
        {
            treeViewRole.Nodes.Clear();
            _dataManager.GenerateRootNode();
            treeViewRole.Nodes.Add(_dataManager.RoleTreeStructure);
            treeViewRole.ExpandAll();
            InitializeMenuTreeView();
        }
        public void InitializeMenuTreeView()
        {
            _roleMenu = new ContextMenuStrip();
            _removeMenuItem.Text = "Remove";
            _addMenuItem.Text = "Add child role";
            _updateMenuItem.Text = "Update";

            _roleMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
            _roleMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);

            //Add the menu items to the menu.
            _roleMenu.Items.AddRange(new ToolStripMenuItem[] { _removeMenuItem, _addMenuItem, _updateMenuItem });
            //Set the ContextMenuStrip property to the ContextMenuStrip.
            this.treeViewRole.ContextMenuStrip = _roleMenu;
        }

        public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            _selectedNode = (RoleTreeNode)treeViewRole.SelectedNode;
            if ((item != null) && (_selectedNode != null))
            {
                if (item.Text == "Update")
                {   /**** A sample code which is frequently used to get a parent form work with a child form ****/
                    Role role = _selectedNode.Role;
                    //fur stands for form update role (ran out of naming ideas)
                    FormUpdateRole fur = new FormUpdateRole(role.UUID, role.Name);
                    fur.ModifyItemCallback = new FormUpdateRole.ModifyItemDelegate(this.ModifyItemCallbackFn);
                    fur.ShowDialog();
                }
                if (item.Text == "Add child role")
                {
                    string parentName = _selectedNode.Role.Name;
                    fAddRole = new FormAddRole(_selectedNode);
                    fAddRole.Show();
                    

                }
                if (item.Text == "Remove")
                {
                    MessageBox.Show("No modal form created to service the remove operation.");
                }
            }

        }//end of contextMenu_ItemClicked
        private void ModifyItemCallbackFn(string uuid, string roleName)
        {
            List<RoleTreeNode> resultNodes = new List<RoleTreeNode>();
            //Find the RoleTreeNode object which has the role object containing the matching
            //UUID value.
            _dataManager.RoleTreeStructure.SearchByUUID(uuid, ref resultNodes);
            //By right, there should only be one RoleTreeNode object found. Therefore,
            //I directly point to the first element inside the List to access the Role object's Name and Text property data.
            resultNodes[0].Role.Name = roleName;
            resultNodes[0].Text = roleName;

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
                    this._removeMenuItem.Enabled = false;
                }
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
            textboxConsole.Text = fAddRole.NodeName;
        }
    }
}
