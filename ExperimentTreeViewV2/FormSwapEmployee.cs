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
    public partial class FormSwapEmployee : Form
    {
        private EmployeeTreeNode _replacingNewNode;
        private DataManager _dataManager;
        private EmployeeTreeNode _selectedNode;
        List<EmployeeTreeNode> foundNodes = new List<EmployeeTreeNode>();

        public FormSwapEmployee(EmployeeTreeNode selectedNode, DataManager dataManager)
        {
            InitializeComponent();
            this._dataManager = dataManager;
            this._selectedNode = selectedNode;
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            _dataManager.EmployeeTreeStructure.SwappingNodes(_selectedNode, _replacingNewNode);
            _dataManager.SaveEmployeeData();
            _dataManager.LoadEmployeeData();
            this.Close();
        }
        
        private void FormSwapEmployee_Load(object sender, EventArgs e)
        {
            this.textboxSelectedNode.Text = _selectedNode.Text;
            _dataManager.LoadEmployeeData();
            this.treeViewEmployee.Nodes.Clear();
            this.treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure);
            this.treeViewEmployee.ExpandAll();
            treeViewEmployee.NodeMouseClick += new TreeNodeMouseClickEventHandler(treeViewEmployee_NodeMouseClick);
        }
        public void treeViewEmployee_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            _replacingNewNode = (EmployeeTreeNode)e.Node;
            if (_replacingNewNode != null)
            {
                this.textBoxUUID.Text = _replacingNewNode.Employee.UUID;
                this.textBoxEmployeeName.Text = _replacingNewNode.Employee.Name;
                if (_replacingNewNode.Employee.Name == "ROOT")
                {
                    this.textboxReportingOff.Text = "N.A.";
                }
                else
                {
                    this.textboxReportingOff.Text = _replacingNewNode.ParentEmployeeTreeNode.Employee.Name;
                }
                this.textBoxSalary.Text = _replacingNewNode.Employee.Salary.ToString();
                this.textBoxEmployeeRole.Text = _replacingNewNode.Employee.PriRole.Name;
                if (_replacingNewNode.Employee.ProjectList.Count == 0)
                {
                    this.textBoxProject.Text = "No project";
                }
                else
                {
                    this.textBoxProject.Text = "tbc";
                }
            }
            //Debug.Write(_selectedNode);
        }
    }
}
