using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExperimentTreeViewV2
{
    public partial class Company_Projects_Simulator : Form
    {
        public FormManageRoles f1 = null;
        public FormManageEmployee f2 = null;
        public FormManageProjects f3 = null;
        public Company_Projects_Simulator()
        {
            InitializeComponent();
            this.employeeToolStripMenuItem.Click += new EventHandler(employeeToolStripMenuItem_Click);
            this.projectToolStripMenuItem.Click += new EventHandler(projectToolStripMenuItem_Click);
            this.roleToolStripMenuItem.Click += new EventHandler(roleToolStripMenuItem_Click);
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 != null)
            {
                f2.Close();
                f2 = new FormManageEmployee();
                if (f1 != null)
                {
                    f1.Hide();
                }
                if (f3 != null)
                {
                    f3.Hide();
                }
                f2.MdiParent = this;
                f2.Show();
            }
            else
            {
                f2 = new FormManageEmployee();
            }
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f3 != null)
            {
                f3.Close();
                f3 = new FormManageProjects();
                if (f2 != null)
                {
                    f2.Hide();
                }
                if (f1 != null)
                {
                    f1.Hide();
                }
                f3.MdiParent = this;
                f3.Show();
            }
            else
            {
                f3 = new FormManageProjects();
            }
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f1 != null)
            {
                f1.Close();
                f1 = new FormManageRoles();
                if (f2 != null)
                {
                    f2.Hide();
                }
                if (f3 != null)
                {
                    f3.Hide();
                }
                f1.MdiParent = this;
                f1.Show();
            }
            else
            {
                f1 = new FormManageRoles();
            }
        }
    }
}
