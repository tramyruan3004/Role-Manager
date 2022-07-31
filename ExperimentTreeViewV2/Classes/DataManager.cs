using System;
using System.Collections.Generic;
using System.Diagnostics;
//namespace for file io
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using ExperimentTreeViewV2.Classes;

//namespace the the Application class
using System.Windows.Forms;

namespace ExperimentTreeViewV2.Classes
{
    [Serializable]
    public class DataManager
        //******************************** IMPORTANT *********************************************
        //About DataManager
        //You should manage all the employee data, role data and project data by applying code
        //in this DataManager instead of having seperate RoleManager, EmployeeManager and ProjectManager class
        //****************************************************************************************
    {
        RoleTreeNode _roleTreeStructure;
        EmployeeTreeNode _employeeTreeStructure;
        private string _filePath; // Saved data file path
        private string _filePathEmployee; // Saved data file path

        public DataManager()
        {
            _filePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Data\\roleNodeStructure.dat";
            _roleTreeStructure = new RoleTreeNode(new Role("ROOT"));
            _filePathEmployee = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Data\\employeeNodeStructure.dat";
            _employeeTreeStructure = new EmployeeTreeNode(new Employee("ROOT", new Role("ROOT"), 0, false));
        }
        public RoleTreeNode GenerateRootNode()
        {
            _roleTreeStructure = new RoleTreeNode(new Role("ROOT"));
            return _roleTreeStructure;
        }
        public EmployeeTreeNode GenerateEmployeeRootNode()
        {
            _employeeTreeStructure = new EmployeeTreeNode(new Employee("ROOT", new Role("ROOT"), 0, false));
            return _employeeTreeStructure;
        }
        public RoleTreeNode GenerateFakeTreeStructure()
        {
            _roleTreeStructure = new RoleTreeNode(new Role("ROOT"));
            Role role1 = new Role("CEO");
            RoleTreeNode node1 = new RoleTreeNode(role1);
            _roleTreeStructure.AddChildRoleTreeNode(node1);
            Role role2 = new Role("ADVISORY BOARD");
            RoleTreeNode node2 = new RoleTreeNode(role2);
            node1.AddChildRoleTreeNode(node2);
            Role role3 = new Role("STAFF DIRECTOR");
            RoleTreeNode node3 = new RoleTreeNode(role3);
            node1.AddChildRoleTreeNode(node3);

            Role role4 = new Role("VOLUNTEER DIRECTOR");
            RoleTreeNode node4 = new RoleTreeNode(role4);
            node1.AddChildRoleTreeNode(node4);
            Role role5 = new Role("FINANCE DIRECTOR");
            RoleTreeNode node5 = new RoleTreeNode(role5);
            node3.AddChildRoleTreeNode(node5);
            Role role5_1 = new Role("FINANCE SPECIALIST");
            RoleTreeNode node5_1 = new RoleTreeNode(role5_1);
            node5.AddChildRoleTreeNode(node5_1);
            Role role6 = new Role("COMMUNICATIONS DIRECTOR");
            RoleTreeNode node6 = new RoleTreeNode(role6);
            node3.AddChildRoleTreeNode(node6);
            Role role6_1 = new Role("COMMUNICATIONS SPECIALIST");
            RoleTreeNode node6_1 = new RoleTreeNode(role6_1);
            node6.AddChildRoleTreeNode(node6_1);
            Role role7 = new Role("FUND RAISING DIRECTOR");
            RoleTreeNode node7 = new RoleTreeNode(role7);
            node3.AddChildRoleTreeNode(node7);
            Role role7_1 = new Role("FUND RAISING SPECIALIST");
            RoleTreeNode node7_1 = new RoleTreeNode(role7_1);
            node7.AddChildRoleTreeNode(node7_1);
            Role role8 = new Role("PROGRAM DIRECTOR");
            RoleTreeNode node8 = new RoleTreeNode(role8);
            node3.AddChildRoleTreeNode(node8);
            Role role8_1 = new Role("PROGRAM SPECIALIST");
            RoleTreeNode node8_1 = new RoleTreeNode(role8_1);
            node8.AddChildRoleTreeNode(node8_1);
            Role role9 = new Role("OPERATIONS DIRECTOR");
            RoleTreeNode node9 = new RoleTreeNode(role9);
            node3.AddChildRoleTreeNode(node9);
            Role role9_1 = new Role("OPERATIONS SPECIALIST");
            RoleTreeNode node9_1 = new RoleTreeNode(role9_1);
            node9.AddChildRoleTreeNode(node9_1);

            node9.AddChildRoleTreeNode(new RoleTreeNode(new Role("TEST1")));
            return _roleTreeStructure;
        }//end of GenerateFakeTreeStructure

        public RoleTreeNode RoleTreeStructure
        {
            get { return _roleTreeStructure; }
            set { _roleTreeStructure = value; }
        }
        public EmployeeTreeNode EmployeeTreeStructure
        {
            get { return _employeeTreeStructure; }
            set { _employeeTreeStructure = value; }
        }
        public void SaveRoleData()
        {
            this.RoleTreeStructure.SaveToFileBinary(_filePath);
        }//end of SaveRoleData

        public RoleTreeNode LoadRoleData()
        {
            this.RoleTreeStructure = this.RoleTreeStructure.ReadFromFileBinary(_filePath);
            this.RoleTreeStructure.RebuildTreeNodes();
            return this.RoleTreeStructure;

        } //end of LoadRoleData method
        public void SaveEmployeeData()
        {
            this.EmployeeTreeStructure.SaveToFileBinary(_filePathEmployee);
        }//end of SaveEmployeeData

        public EmployeeTreeNode LoadEmployeeData()
        {
            this.EmployeeTreeStructure = this.EmployeeTreeStructure.ReadFromFileBinary(_filePathEmployee);
            this.EmployeeTreeStructure.RebuildTreeNodes();
            return this.EmployeeTreeStructure;

        } //end of LoadEmployeeData method
        
        public bool checkRoleFileExist()
        {
            if (File.Exists(_filePath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkEmployeeFileExist()
        {
            if (File.Exists(_filePathEmployee))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }//end of class DataManager
}//end of namespace
