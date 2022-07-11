using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Define the namespace
using ExperimentTreeViewV2.Classes;
namespace ExperimentTreeViewV2
{
    public partial class Form1 : Form
    {
        DataManager roleManager;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            roleManager = new DataManager();
        }

        private void buttonSetupTreeStructure_Click(object sender, EventArgs e)
        {
            treeViewRole.Nodes.Clear();
            roleManager.GenerateFakeTreeStructure();
            treeViewRole.Nodes.Add(roleManager.RoleTreeStructure);
            treeViewRole.ExpandAll();
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            roleManager.SaveRoleData();
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            roleManager.LoadRoleData();
            treeViewRole.Nodes.Clear();
            treeViewRole.Nodes.Add(roleManager.RoleTreeStructure);
            treeViewRole.ExpandAll();
        }
    }
}
