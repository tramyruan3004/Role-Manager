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
    public partial class FormAddRole : Form

    {
        private RoleTreeNode _pNode;
        private string nodeName;
        public string NodeName
        {
            get { return nodeName; }
            set { nodeName = value; }
        }

        public FormAddRole(RoleTreeNode pNode)
        {
            InitializeComponent();
            this._pNode = pNode;
            this.textboxParentRole.Text = this._pNode.Role.Name;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NodeName = this.textboxNodeName.Text;
            MessageBox.Show("Role has been added!");
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
