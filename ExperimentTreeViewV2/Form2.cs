using ExperimentTreeViewV2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExperimentTreeViewV2
{
    public partial class Form2 : Form
    {
        DataManager _dataManager;
        RoleTreeNode _selectedNode;
        private ContextMenuStrip _roleMenu;
        //Create some menu items.
        ToolStripMenuItem _removeMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _addMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _updateMenuItem = new ToolStripMenuItem();
  
        public Form2()
        {
            InitializeComponent();
            _dataManager = new DataManager();
            _selectedNode = null;
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            _dataManager.LoadRoleData();
            treeViewRole.Nodes.Clear();
            treeViewRole.Nodes.Add(_dataManager.RoleTreeStructure);
            treeViewRole.ExpandAll();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeMenuTreeView();
        }
        //Reference: https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-attach-a-shortcut-menu-to-a-treeview-node?view=netframeworkdesktop-4.8
        //Declare the ContextMenuStrip
        


        public void InitializeMenuTreeView()
        {

            // Create the ContextMenuStrip.
            _roleMenu = new ContextMenuStrip();
            _removeMenuItem.Text = "Remove";
            _addMenuItem.Text = "Add child role";
            _updateMenuItem.Text = "Update";

            //Reference: https://stackoverflow.com/questions/5789023/how-to-respond-to-a-contextmenustrip-item-click
            //When the menu item is clicked, need the logic inside the contextMenu_ItemClicked method to
            //decide on operations such as make a form interface to appear for update, make a dialog interface appear to confirm delete etc.
            _roleMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
            //When the menu is opening, need some logic to inspect the selected node's info so that
            //the correct menu item is displayed or enabled. The logic is defined inside the contextMenu_Opening method
            _roleMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);

            //Add the menu items to the menu.
            _roleMenu.Items.AddRange(new ToolStripMenuItem[]{_removeMenuItem, _addMenuItem, _updateMenuItem});
            //Set the ContextMenuStrip property to the ContextMenuStrip.
            this.treeViewRole.ContextMenuStrip = _roleMenu;
        }
        public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            _selectedNode = (RoleTreeNode)treeViewRole.SelectedNode;
            if ((item != null )&& (_selectedNode!=null))
            {
                if(item.Text == "Update")
                {   /**** A sample code which is frequently used to get a parent form work with a child form ****/
                    Role role = _selectedNode.Role;
                    //fur stands for form update role (ran out of naming ideas)
                    FormUpdateRole fur = new FormUpdateRole(role.UUID,role.Name);
                    fur.ModifyItemCallback = new FormUpdateRole.ModifyItemDelegate(this.ModifyItemCallbackFn);
                    fur.ShowDialog();
                }
                if (item.Text == "Add child role")
                {
                    MessageBox.Show("No modal form created to service the add role operation.");
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

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            _dataManager.SaveRoleData();
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            _selectedNode = (RoleTreeNode)treeViewRole.SelectedNode;
            //Enable all menu items first. Then disable the menu items which are not appropriate
            foreach(ToolStripMenuItem item in _roleMenu.Items)
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
    }//end of class


}
