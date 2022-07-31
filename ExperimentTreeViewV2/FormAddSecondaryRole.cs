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
    public partial class FormAddSecondaryRole : Form
    {
        private DataManager _employeeDataManager;
        private DataManager _roleDataManager;
        private string _nodeRoleName;
        private Employee _employee;
        private string _reportingOffName;
        
        private List<RoleTreeNode> _roleNodesList;

        public delegate void AddSecRoleDelegate(string uuid, string employeeName, double salary, string reportingOffUUID, Role priRole, Role SecRole, bool dummyStat);
        public AddSecRoleDelegate AddSecRoleCallback;
        public FormAddSecondaryRole(string uuid, string employeeName, double salary, string reportingOffName, Role priRole, List<RoleTreeNode> roleNodeList, DataManager employeeDataManager, DataManager roleDataManager, bool dummyStat)
        {
            InitializeComponent();
            this._employee = new Employee();
            this._employee.Name = employeeName;
            this._employee.UUID = uuid;
            this._reportingOffName = reportingOffName;
            this._employee.PriRole = priRole;
            this._employee.Salary = salary;
            this._roleNodesList = roleNodeList;
            this._employeeDataManager = employeeDataManager;
            this._roleDataManager = roleDataManager;
            this.checkBoxDummy.Checked = dummyStat;
        }
        private void FormAddSecondaryRole_Load(object sender, EventArgs e)
        {
            this.textboxNodeName.Text = _employee.Name;
            this.textBoxUUID.Text = _employee.UUID;
            this.textboxNodeSalary.Text = _employee.Salary.ToString();
            this.comboBoxReportingOff.Text = _reportingOffName;
            this.comboBoxRoles.Text = _employee.PriRole.Name;
            if (_roleNodesList != null)
            {
                int i;
                for (i = 0; i < _roleNodesList.Count; i++)
                {
                    comboBoxRoles.Items.Add(_roleNodesList[i].Role.Name);
                }//load the child nodes to a list first from the selected node
            }
            comboBoxReportingOff.DisplayMember = "Text";
            comboBoxReportingOff.ValueMember = "Value";
            Debug.WriteLine(_nodeRoleName);
        }
        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _nodeRoleName = (string)comboBoxRoles.SelectedItem;
            List<RoleTreeNode> selectedRoleNode = new List<RoleTreeNode>();
            _roleDataManager.RoleTreeStructure.SearchByName(_nodeRoleName, ref selectedRoleNode);
            string parentRoleUUID = selectedRoleNode[0].ParentRoleTreeNode.Role.UUID;
            List<EmployeeTreeNode> selectedParentNodesList = new List<EmployeeTreeNode>();
            _employeeDataManager.EmployeeTreeStructure.SearchByRoleUUID(parentRoleUUID, ref selectedParentNodesList);
            foreach(EmployeeTreeNode pName in selectedParentNodesList)
            {
                //Debug.WriteLine(pName.Employee.Name);
                comboBoxReportingOff.Items.Add(new { Text = pName.Employee.Name, Value = pName.Employee.UUID });
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Role secRole = new Role();
            if (_roleNodesList != null)
            {
                int i;
                for (i = 0; i < _roleNodesList.Count; i++)
                {
                    if (_nodeRoleName == _roleNodesList[i].Role.Name)
                    {
                        secRole = _roleNodesList[i].Role;
                    }
                }//load the child nodes to a list first from the selected node
            }
            string name = textboxNodeName.Text.Trim();
            string uuid = textBoxUUID.Text.Trim();
            double salary = Convert.ToDouble(textboxNodeSalary.Text.Trim());
            string reportingOffUUID = comboBoxReportingOff.SelectedItem.GetType().GetProperty("Value").GetValue(comboBoxReportingOff.SelectedItem, null).ToString();
            Role priRole = _employee.PriRole;
            bool dummyStat = checkBoxDummy.Checked;
            if (name != "")
            {
                AddSecRoleCallback(uuid, name, salary, reportingOffUUID, priRole, secRole, dummyStat);
                this.DialogResult = DialogResult.OK;
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
