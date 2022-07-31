using System;
using System.Collections.Generic;
using System.Text;

namespace ExperimentTreeViewV2.Classes
{
    [Serializable]
    public class Project
    {
        private string _uuid; // Project UUID
        private string _name; // Project Name
        private double _revenue; // Project Revenue
        private Employee _projLeader; //ProjectLeader
        public Project(string name, double revenue, Employee projectLeader)
        {
            _uuid = General.GenerateUUID();
            _name = name;
            _revenue = revenue;
            _projLeader = projectLeader;

        } // end of constructor
          //end of two constructors
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        } // End of UUID property
        public string Name
        {
            get { return _name; }
            set { _name = value;}
        } // End of Name property
        public double Revenue
        {
            get { return _revenue; }
            set { _revenue = value; }
        } // End of Revenue property
        public Employee ProjectLeader
        {
            get { return _projLeader; }
            set { _projLeader = value; }
        } // End of Name property
    }
   


}
