using System;
using System.Collections.Generic;
using System.Text;


namespace ExperimentTreeViewV2.Classes
{
    [Serializable]
    public class Employee
    {
        private string _uuid; // Employee UUID
        private string _name; // Employee Name
        private Role _priRole;//Employee Role
        private Role _secRole;//Employee Role
        private List<Project> _projectList = new List<Project>();
        private double _salary;
        private EmployeeTreeNode _container; // References the RoleTreeNode object that contains the role
        private bool _dummyStat;
        public Employee()
        {
        }//end of constructor
        public Employee(string name, Role priRole , double salary, bool dummyStat)
        {
            _uuid = General.GenerateUUID();
            _name = name;
            _priRole = priRole;
            _salary = salary;
            _dummyStat = dummyStat;
        } // end of constructor
        public Employee(string name, Role priRole, Role secRole, double salary, bool dummyStat)
        {
            _uuid = General.GenerateUUID();
            _name = name;
            _priRole = priRole;
            _secRole = secRole;
            _salary = salary;
            _dummyStat = dummyStat;
        } // end of constructor
          //end of three constructors

        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        } // Employee UUID
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } // Employee Name
        public Role PriRole
        {
            get { return _priRole; }
            set { _priRole = value; }
        }//Employee Role
        public Role SecRole
        {
            get { return _secRole; }
            set { _secRole = value; }
        }//Employee Role
        public List<Project> ProjectList
        {
            get { return _projectList; }
            set { _projectList = value; }
        }
        public bool DummyStat
        {
            get { return _dummyStat; }
            set { _dummyStat = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public EmployeeTreeNode Container
        {
            get { return _container; }
            set { _container = value; }
        }
        //public void EditEmployee(string name, Role employeeRole, Project project, double salary)
        //{
        //    _name = name;
        //    _employeeRole = employeeRole;
        //    _project = project;
        //    _salary = salary;
        //}// End of EditEmployee method
        public void AddProject(Project proj)
        {
            _projectList.Add(proj);
        } // End of AddProject method
    }
}
