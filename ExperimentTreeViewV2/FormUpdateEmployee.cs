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
    public partial class FormUpdateEmployee : Form
    {
        private string _nodeRoleName;
        private string _oriEmployeeName;
        private double _parentSalary;
        private Employee _employee;
        private string _reportingOffName;
        private List<RoleTreeNode> _roleNodesList;
        public delegate void ModifyItemDelegate(string uuid, string oriEmployeeName, string employeeName, double salary, string reportingOffName, Role priRole, Role secRole, bool dummyStat);
        public ModifyItemDelegate ModifyItemCallback;
        public FormUpdateEmployee(double parentSalary, string uuid, string employeeName, double salary, string reportingOffName, Role priRole, Role secRole, bool dummyStat)
        {
            InitializeComponent();
            this._employee = new Employee();
            this._employee.Name = employeeName;
            this._employee.UUID = uuid;
            this._reportingOffName = reportingOffName;
            this._employee.PriRole = priRole;
            this._employee.SecRole = secRole;
            this._employee.Salary = salary;
            this._employee.DummyStat = dummyStat;
            this._oriEmployeeName = employeeName;
            this._parentSalary = parentSalary;

        }
    public FormUpdateEmployee(string uuid, string employeeName, double salary, string reportingOffName, Role priRole, Role secRole, List<RoleTreeNode> roleNodeList, bool dummyStat)
        {
            InitializeComponent();
            this.textboxNodeName.Enabled = false;
            this.textboxNodeSalary.Enabled = false;
            this.textboxReportingOff.Enabled = false;
            this.Text = "Edit_Employee_Role";
            this.checkBoxDummy.Enabled = false;

            this._employee = new Employee();
            this._employee.Name = employeeName;
            this._employee.UUID = uuid;
            this._reportingOffName = reportingOffName;
            this._employee.PriRole = priRole;
            this._employee.SecRole = secRole;
            this._employee.Salary = salary;
            this._employee.DummyStat = dummyStat;
            this._roleNodesList = roleNodeList;
            this._oriEmployeeName = employeeName;
        }


        private void FormUpdateEmployee_Load(object sender, EventArgs e)
        {
            this.textboxNodeName.Text = _employee.Name;
            this.textBoxUUID.Text = _employee.UUID;
            this.textboxNodeSalary.Text = _employee.Salary.ToString();
            this.textboxReportingOff.Text = _reportingOffName;
            this.comboBoxReportingOff.Text = _reportingOffName;
            this.comboBoxRoles.Text = _employee.PriRole.Name;
            this.checkBoxDummy.Checked = _employee.DummyStat;
            if (_roleNodesList != null)
            {
                int i;
                for (i = 0; i < _roleNodesList.Count; i++)
                {
                    comboBoxRoles.Items.Add(_roleNodesList[i].Role.Name);
                }//load the child nodes to a list first from the selected node
            }
            Debug.WriteLine(_nodeRoleName);
        }
        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _nodeRoleName = (string)comboBoxRoles.SelectedItem;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (_roleNodesList != null)
            {
                int i;
                for (i = 0; i < _roleNodesList.Count; i++)
                {
                    if (_nodeRoleName == _roleNodesList[i].Role.Name)
                    {
                        _employee.PriRole = _roleNodesList[i].Role;
                    }
                }//load the child nodes to a list first from the selected node
            }
            string oriName = _oriEmployeeName;
            string name = textboxNodeName.Text.Trim();
            string uuid = textBoxUUID.Text.Trim();

            double salary = Convert.ToDouble(textboxNodeSalary.Text.Trim());
            string reportingOffName = textboxReportingOff.Text.Trim();
            Role priRole = _employee.PriRole;
            Role secRole = _employee.SecRole;
            bool dummyStat = checkBoxDummy.Checked;
            if (name != "")
            {
                ModifyItemCallback(uuid, oriName, name, salary, reportingOffName, priRole, secRole, dummyStat);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void checkBoxDummy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDummy.Checked == true)
            {
                this._employee.DummyStat = true;
                this.textboxNodeName.Text = "DUMMY";
                this.textboxNodeName.Enabled = false;
            }
            else
            {
                this._employee.DummyStat = false;
                this.textboxNodeName.Text = _oriEmployeeName;
                this.textboxNodeName.Enabled = true;
            }
        }

        private void textboxNodeSalary_TextChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled = true;
            try
            {
                if (double.Parse(textboxNodeSalary.Text) > _parentSalary && this.textboxReportingOff.Text != "ROOT")
                {
                    buttonEdit.Enabled = false;
                }
            }
            catch
            {
                buttonEdit.Enabled = false;
                return;
            }//End of try..catch
        }

        private void textboxNodeName_TextChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled = true;
            if (this.textboxNodeName.Text == "")
            {
                buttonEdit.Enabled = false;
            }
        }
    }
}
