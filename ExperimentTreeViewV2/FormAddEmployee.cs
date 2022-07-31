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
    public partial class FormAddEmployee : Form
    {
        
        private EmployeeTreeNode _pNode;
        private string _nodeName = "";
        private double _nodeSalary = -1;
        private string _nodeRoleName = "";
        private bool _nodeDummyStat;
        private List<RoleTreeNode> _roleNodesList;

        public string NodeName
        {
            get { return _nodeName; }
            set { _nodeName = value; }
        }
        public bool NodeDummyStat
        {
            get { return _nodeDummyStat; }
            set { _nodeDummyStat = value; }
        }
        public double NodeSalary
        {
            get { return _nodeSalary; }
            set { _nodeSalary = value; }
        }
        public string NodeRoleName
        {
            get { return _nodeRoleName; }
            set { _nodeRoleName = value; }
        }
        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            this.textboxReportingOff.Text = this._pNode.Employee.Name;
            int i;
            for (i = 0; i < _roleNodesList.Count; i++){
                comboBoxRoles.Items.Add(_roleNodesList[i].Role.Name);
            }//load the child nodes to a list first from the selected node
        }
        public FormAddEmployee(EmployeeTreeNode pNode, List<RoleTreeNode> pRoleNodes)
        {
            InitializeComponent();
            this._pNode = pNode;
            this._roleNodesList = pRoleNodes;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.textboxNodeName.Text != "" || (string)comboBoxRoles.SelectedItem != "Select the role")
            {
                this.NodeName = this.textboxNodeName.Text;
                this.NodeSalary = Convert.ToDouble(this.textboxNodeSalary.Text);
                this.NodeDummyStat = this._nodeDummyStat;
                MessageBox.Show("Employee has been added!");
                this.Close();
            }
            else
            {
                if (this.textboxNodeName.Text == "")
                {
                    MessageBox.Show("Please enter Employee Name!");
                }
                else if ((string)comboBoxRoles.SelectedItem != "Select the role")
                {
                    MessageBox.Show("Please select Employee Role!");
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _nodeRoleName = (string)comboBoxRoles.SelectedItem;
        }

        private void checkBoxDummy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDummy.Checked == true)
            {
                this._nodeDummyStat = true;
                this.textboxNodeName.Text = "DUMMY";
                this.textboxNodeName.Enabled = false;
            }
            else
            {
                this._nodeDummyStat = false;
                this.textboxNodeName.Clear();
                this.textboxNodeName.Enabled = true;
            }
        }

        private void textboxNodeSalary_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = true;
            try
            {
                this.NodeSalary = double.Parse(textboxNodeSalary.Text);
            }
            catch
            {
                buttonAdd.Enabled = false;
                return;
            }//End of try..catch
        }

        private void textboxNodeName_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = true;
            if (this.textboxNodeName.Text == "")
            {
                buttonAdd.Enabled = false;
            }
        }
    }
}
