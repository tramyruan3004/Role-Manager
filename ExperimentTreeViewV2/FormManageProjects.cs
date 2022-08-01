using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using ExperimentTreeViewV2.Classes;


namespace ExperimentTreeViewV2
{
    public partial class FormManageProjects : Form
    {
        List<Project> _projectList;
        DataManager _employeeDataManager;
        DataManager _roleDataManager;
        List<List<string>> _completeRoleTeamUUIDList;
        List<List<EmployeeTreeNode>> _completeTeamList;
        string projFilepath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Data\\projectList.dat";
        public FormManageProjects()
        {
            InitializeComponent();
            _employeeDataManager = new DataManager();
            _roleDataManager = new DataManager();
            _projectList = new List<Project>();
            _completeRoleTeamUUIDList = new List<List<string>>();
            _completeTeamList = new List<List<EmployeeTreeNode>>();
        }

        private void FormManageProjects_Load(object sender, EventArgs e)
        {
            //ComboBoxMode
            comboBoxMode.Items.Add("View");
            comboBoxMode.Items.Add("Add");
            comboBoxMode.Items.Add("Edit");
            comboBoxMode.SelectedItem = "View";
            //ComboxTeamLeader
            comboBoxTeamLeaderAdd.DisplayMember = "Text";
            comboBoxTeamLeaderAdd.ValueMember = "Value";
            comboBoxTeamLeaderEdit.DisplayMember = "Text";
            comboBoxTeamLeaderEdit.ValueMember = "Value";

            _roleDataManager.LoadRoleData();
            _roleDataManager.RoleTreeStructure.ExtractCompleteTeam(_completeRoleTeamUUIDList);
            //load the employee data
            _employeeDataManager.GenerateEmployeeRootNode();
            _employeeDataManager.EmployeeTreeStructure.ExtractCompleteTeam(_completeRoleTeamUUIDList, _completeTeamList);
            treeViewEmployee.Nodes.Clear();
            treeViewEmployee.Nodes.Add(_employeeDataManager.EmployeeTreeStructure);
            treeViewEmployee.ExpandAll();

        }
        private void buttonExpandAll_Click(object sender, EventArgs e)
        {
            treeViewEmployee.ExpandAll();
        }

        private void buttonCollapseAll_Click(object sender, EventArgs e)
        {
            treeViewEmployee.CollapseAll();
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMode.SelectedItem.ToString() == "View")
            {
                this.groupBoxAddProj.Enabled = false;
                this.groupBoxEditProj.Enabled = false;
            }
            else if (comboBoxMode.SelectedItem.ToString() == "Add")
            {
                this.groupBoxAddProj.Enabled = true;
                this.groupBoxEditProj.Enabled = false;
            }
            else if (comboBoxMode.SelectedItem.ToString() == "Edit")
            {
                this.groupBoxAddProj.Enabled = false;
                this.groupBoxEditProj.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _employeeDataManager.SaveEmployeeData();
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                Stream stream = new FileStream(projFilepath, FileMode.OpenOrCreate, FileAccess.Write);

                bf.Serialize(stream, _projectList);
                stream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Data is added to file");
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            _employeeDataManager.GenerateEmployeeRootNode();
            if (_employeeDataManager.checkEmployeeFileExist())
            {
                _employeeDataManager.LoadEmployeeData();
            }
            _employeeDataManager.EmployeeTreeStructure.ExtractCompleteTeam(_completeRoleTeamUUIDList, _completeTeamList);
            treeViewEmployee.Nodes.Clear();
            treeViewEmployee.Nodes.Add(_employeeDataManager.EmployeeTreeStructure);
            treeViewEmployee.ExpandAll();
            try
            {
                Stream stream = new FileStream(@projFilepath, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                _projectList = new List<Project>();
                if (stream.Length != 0)
                {
                    _projectList = (List<Project>)bf.Deserialize(stream);
                }
                stream.Close();
                listViewProj.Items.Clear();
                foreach (Project newProj in _projectList)
                {
                    ListViewItem listViewProjItem = new ListViewItem(newProj.UUID);
                    listViewProjItem.SubItems.Add(newProj.Name);
                    listViewProjItem.SubItems.Add(newProj.Revenue.ToString());
                    listViewProjItem.SubItems.Add(newProj.ProjectLeader.Name);
                    listViewProj.Items.Add(listViewProjItem);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Unable to find file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearchForTeamAdd_Click(object sender, EventArgs e)
        {
            treeViewEmployee.Nodes.Clear();
            treeViewEmployee.Nodes.Add(_employeeDataManager.EmployeeTreeStructure);
            treeViewEmployee.ExpandAll();

            comboBoxTeamLeaderAdd.Items.Clear();
            double inputProjectRevenue;
            inputProjectRevenue = Convert.ToDouble(this.textBoxRevenueAdd.Text);
            List<double> teamSalaryList = new List<double>();
            foreach (List<EmployeeTreeNode> oneCompleteTeam in _completeTeamList)
            {
                double cost = 0;
                foreach (EmployeeTreeNode employee in oneCompleteTeam)
                {
                    cost += employee.Employee.Salary;
                }
                teamSalaryList.Add(cost);
            }
            for (int i = 0; i < teamSalaryList.Count; i++)
            {
                if (inputProjectRevenue <= teamSalaryList[i])
                {

                    comboBoxTeamLeaderAdd.Items.Add(new { Text = _completeTeamList[i][0].Text, Value = _completeTeamList[i][0].Employee.UUID });
                    List<EmployeeTreeNode> resultNodes = new List<EmployeeTreeNode>();
                    _employeeDataManager.EmployeeTreeStructure.SearchByUUID(_completeTeamList[i][0].Employee.UUID, ref resultNodes);
                    resultNodes[0].BackColor = Color.Yellow;
                }
            }
        }

        private void buttonConfirmAdd_Click(object sender, EventArgs e)
        {
            string _selectedProjLeaderUUID;

            List<EmployeeTreeNode> resultNodes = new List<EmployeeTreeNode>();
            string projName = this.textBoxProjNameAdd.Text;
            double inputProjectRevenue = Convert.ToDouble(this.textBoxRevenueAdd.Text);

            _selectedProjLeaderUUID = comboBoxTeamLeaderAdd.SelectedItem.GetType().GetProperty("Value").GetValue(comboBoxTeamLeaderAdd.SelectedItem, null).ToString();
            Debug.WriteLine(_selectedProjLeaderUUID);
            _employeeDataManager.EmployeeTreeStructure.SearchByUUID(_selectedProjLeaderUUID, ref resultNodes);
            Debug.WriteLine(resultNodes[0]);
            Project newProj = new Project(projName, inputProjectRevenue, resultNodes[0].Employee);
            _projectList.Add(newProj); //display on the project form

            //add to project property of the resultNodes
            if (!resultNodes[0].Employee.ProjectList.Contains(newProj))
            {
                resultNodes[0].Employee.AddProject(newProj);
            }
            foreach (EmployeeTreeNode emp in resultNodes[0].ChildrenEmployeeNodes)
            {
                Debug.WriteLine(emp);
                if (!emp.Employee.ProjectList.Contains(newProj))
                {
                    emp.Employee.AddProject(newProj);
                }
            }

            ListViewItem listViewProjItem = new ListViewItem(newProj.UUID);
            listViewProjItem.SubItems.Add(newProj.Name);
            listViewProjItem.SubItems.Add(newProj.Revenue.ToString());
            listViewProjItem.SubItems.Add(newProj.ProjectLeader.Name);
            listViewProj.Items.Add(listViewProjItem);


            this.textboxConsole.Text = "Project added:\nName:" + newProj.Name +
                "\nRevenue:" + newProj.Revenue.ToString() + "\nTeam Leader:" + newProj.ProjectLeader.Name;

            comboBoxMode.SelectedItem = "View";
            this.textBoxProjNameAdd.Clear();
            this.textBoxRevenueAdd.Clear();
            this.comboBoxTeamLeaderAdd.Text = null;
            this.comboBoxTeamLeaderAdd.Items.Clear();
            foreach(Project proj in _projectList)
            {
                Debug.WriteLine(proj.Name, proj.ProjectLeader.Name);

            }
        }

        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            comboBoxMode.SelectedItem = "View";
            this.textBoxProjNameAdd.Clear();
            this.textBoxRevenueAdd.Clear();
            this.comboBoxTeamLeaderAdd.Text = null;
            this.comboBoxTeamLeaderAdd.Items.Clear();
        }

        private void buttonSearchForTeamEdit_Click(object sender, EventArgs e)
        {
            comboBoxTeamLeaderEdit.Items.Clear();
            double inputProjectRevenue;
            inputProjectRevenue = Convert.ToDouble(this.textBoxRevenueEdit.Text);
            List<double> teamSalaryList = new List<double>();
            foreach (List<EmployeeTreeNode> oneCompleteTeam in _completeTeamList)
            {
                double cost = 0;
                foreach (EmployeeTreeNode employee in oneCompleteTeam)
                {
                    cost += employee.Employee.Salary;
                }
                teamSalaryList.Add(cost);
            }
            for (int i = 0; i < teamSalaryList.Count; i++)
            {
                if (inputProjectRevenue <= teamSalaryList[i])
                {
                    comboBoxTeamLeaderEdit.Items.Add(new { Text = _completeTeamList[i][0].Text, Value = _completeTeamList[i][0].Employee.UUID });
                    List<EmployeeTreeNode> resultNodes = new List<EmployeeTreeNode>();
                    _employeeDataManager.EmployeeTreeStructure.SearchByUUID(_completeTeamList[i][0].Employee.UUID, ref resultNodes);
                    resultNodes[0].BackColor = Color.Yellow;
                }
            }
        }

        private void buttonConfirmEdit_Click(object sender, EventArgs e)
        {
            string _selectedProjLeaderUUID;
            string _selectedProjItem = textBoxProjUUIDEdit.Text;
            foreach (Project project in _projectList)
            {
                if (project.UUID == _selectedProjItem)
                {
                    project.Name = this.textBoxProjNameEdit.Text; //get the name of the proj back to projectList in Proj form itself
                    project.Revenue = Convert.ToDouble(this.textBoxRevenueEdit.Text); //get the revenue of the proj back to projectList in Proj form itself
                    //extract the new project Leader UUID from the input
                    string _selectPrevLeaderUUID = project.ProjectLeader.UUID;
                    List < EmployeeTreeNode> resultPrevLeaderNodes = new List<EmployeeTreeNode>();
                    _employeeDataManager.EmployeeTreeStructure.SearchByUUID(_selectPrevLeaderUUID, ref resultPrevLeaderNodes);
                    if (comboBoxTeamLeaderEdit.Text == resultPrevLeaderNodes[0].Text)
                    {
                        _selectedProjLeaderUUID = _selectPrevLeaderUUID;
                        Debug.WriteLine("Success to recognise");
                    }
                    else
                    {
                        _selectedProjLeaderUUID = comboBoxTeamLeaderEdit.SelectedItem.GetType().GetProperty("Value").GetValue(comboBoxTeamLeaderEdit.SelectedItem, null).ToString(); //get the new leader
                        for (int i = 0; i < resultPrevLeaderNodes[0].Employee.ProjectList.Count; i++)
                        {
                            if (resultPrevLeaderNodes[0].Employee.ProjectList[i].UUID == project.UUID)
                            {
                                resultPrevLeaderNodes[0].Employee.ProjectList.Remove(resultPrevLeaderNodes[0].Employee.ProjectList[i]);
                            }
                        }
                        foreach (EmployeeTreeNode childNode in resultPrevLeaderNodes[0].ChildrenEmployeeNodes)
                        {
                            for (int i = 0; i < childNode.Employee.ProjectList.Count; i++)
                            {
                                if (childNode.Employee.ProjectList[i].UUID == project.UUID)
                                {
                                    childNode.Employee.ProjectList.Remove(childNode.Employee.ProjectList[i]);
                                }
                            }
                        }
                        List<EmployeeTreeNode> resultNodes = new List<EmployeeTreeNode>();
                        _employeeDataManager.EmployeeTreeStructure.SearchByUUID(_selectedProjLeaderUUID, ref resultNodes);
                        project.ProjectLeader = resultNodes[0].Employee; //replace the projLeader of the proj back to projectList in Proj form itself

                        //modify in the leader and subordinates nodes abt project data
                        if (!resultNodes[0].Employee.ProjectList.Contains(project))
                        {
                            resultNodes[0].Employee.AddProject(project);
                        }
                        foreach (EmployeeTreeNode childNode in resultNodes[0].ChildrenEmployeeNodes)
                        {
                            if (!childNode.Employee.ProjectList.Contains(project))
                            {
                                childNode.Employee.AddProject(project);
                            }
                        }
                    }
                    this.textboxConsole.Text = "Project edited:\nName:" + project.Name + "\nRevenue:" + project.Revenue.ToString() + "\nTeam Leader:" + project.ProjectLeader.Name;

                }
            }
            //Update the listView control
            listViewProj.Items.Clear();
            foreach (Project newProj in _projectList)
            {
                ListViewItem listViewProjItem = new ListViewItem(newProj.UUID);
                listViewProjItem.SubItems.Add(newProj.Name);
                listViewProjItem.SubItems.Add(newProj.Revenue.ToString());
                listViewProjItem.SubItems.Add(newProj.ProjectLeader.Name);
                listViewProj.Items.Add(listViewProjItem);
            }
            //reset the form
            comboBoxMode.SelectedItem = "View";
            this.textBoxProjNameEdit.Clear();
            this.textBoxRevenueEdit.Clear();
            this.comboBoxTeamLeaderEdit.Text = null;
            this.comboBoxTeamLeaderEdit.Items.Clear();
        }

        private void listViewProj_ItemSelectionChanged(Object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (comboBoxMode.SelectedItem.ToString() == "Edit")
            {
                ListViewItem _selectedItem = (ListViewItem)e.Item;
                foreach (Project project in _projectList)
                {
                    if (project.UUID == _selectedItem.Text)
                    {
                        this.textBoxProjUUIDEdit.Text = project.UUID;
                        this.textBoxProjNameEdit.Text = project.Name;
                        this.textBoxRevenueEdit.Text = project.Revenue.ToString();
                        List<EmployeeTreeNode> resultNodes = new List<EmployeeTreeNode>();
                        _employeeDataManager.EmployeeTreeStructure.SearchByUUID(project.ProjectLeader.UUID, ref resultNodes);
                        this.comboBoxTeamLeaderEdit.Text = resultNodes[0].Text;
                    }
                }
            }
        }

        private void buttonDeleteProjEdit_Click(object sender, EventArgs e)
        {
            string _selectedProjItem = listViewProj.SelectedItems[0].Text;
            for(int j = 0; j < _projectList.Count; j++)
            {
                if (_projectList[j].UUID == _selectedProjItem)
                {
                    List<EmployeeTreeNode> resultNodes = new List<EmployeeTreeNode>();
                    _employeeDataManager.EmployeeTreeStructure.SearchByUUID(_projectList[j].ProjectLeader.UUID, ref resultNodes);
                    for (int i = 0; i < resultNodes[0].Employee.ProjectList.Count; i++)
                    {
                        if (resultNodes[0].Employee.ProjectList[i].UUID == _projectList[j].UUID)
                        {
                            resultNodes[0].Employee.ProjectList.Remove(resultNodes[0].Employee.ProjectList[i]);
                        }
                    }
                    foreach (EmployeeTreeNode childNode in resultNodes[0].ChildrenEmployeeNodes)
                    {
                        for (int i = 0; i < childNode.Employee.ProjectList.Count; i++)
                        {
                            if (childNode.Employee.ProjectList[i].UUID == _projectList[j].UUID)
                            {
                                childNode.Employee.ProjectList.Remove(childNode.Employee.ProjectList[i]);
                            }
                        }
                    }
                    this.textboxConsole.Text = "Project deleted:\nName:" + _projectList[j].Name + "\nRevenue:" + _projectList[j].Revenue.ToString() + "\nTeam Leader:" + _projectList[j].ProjectLeader.Name;
                    _projectList.Remove(_projectList[j]);//delete project in the projectList in Project form itself

                }
            }
            //Update the listView control
            listViewProj.Items.Clear();
            foreach (Project newProj in _projectList)
            {
                ListViewItem listViewProjItem = new ListViewItem(newProj.UUID);
                listViewProjItem.SubItems.Add(newProj.Name);
                listViewProjItem.SubItems.Add(newProj.Revenue.ToString());
                listViewProjItem.SubItems.Add(newProj.ProjectLeader.Name);
                listViewProj.Items.Add(listViewProjItem);
            }

            //reset the form
            comboBoxMode.SelectedItem = "View";
            this.textBoxProjNameEdit.Clear();
            this.textBoxRevenueEdit.Clear();
            this.comboBoxTeamLeaderEdit.Text = null;
            this.comboBoxTeamLeaderEdit.Items.Clear();
        }
    }
}
