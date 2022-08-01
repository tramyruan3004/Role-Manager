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
        private string _nodeName = "";
        public string NodeName
        {
            get { return _nodeName; }
            set { _nodeName = value; }
        }

        public FormAddRole(RoleTreeNode pNode)
        {
            InitializeComponent();
            this._pNode = pNode;
            this.textboxParentRole.Text = this._pNode.Role.Name;
            this.checkBoxProjectLeader.Checked = false;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textboxNodeName.Text != "")
            {
                this.NodeName = this.textboxNodeName.Text;
                MessageBox.Show("Role has been added!");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
