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
