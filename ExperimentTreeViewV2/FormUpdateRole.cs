using ExperimentTreeViewV2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExperimentTreeViewV2
{
    public partial class FormUpdateRole : Form
    {
        private Role _oneRole;
        private string _parentName;
        private bool _qualified;
        public delegate void ModifyItemDelegate(string uuid, string roleName, bool projectLeaderStat);
        public ModifyItemDelegate ModifyItemCallback;
        public FormUpdateRole()
        {
            InitializeComponent();
        }
        //need a constructor which can receive role name input
        public FormUpdateRole(string uuid, string roleName, string parentName, bool projectLeaderStat, bool qualifiedProjLead)
        {
            InitializeComponent();
            this._oneRole = new Role();
            this._oneRole.Name = roleName;
            this._oneRole.UUID = uuid;
            this._parentName = parentName;
            this._oneRole.ProjectLeader = projectLeaderStat;
            this._qualified = qualifiedProjLead;
        }
        private void FormUpdateRole_Load(object sender, EventArgs e)
        {
            this.textboxRoleName.Text = _oneRole.Name;
            this.textboxUUID.Text = _oneRole.UUID;
            this.textBoxParentName.Text = _parentName;
            this.checkBoxProjectLeader.Checked = _oneRole.ProjectLeader;
        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            if(textboxRoleName.Text != "")
            {
                string name = textboxRoleName.Text.Trim();
                string uuid = textboxUUID.Text.Trim();
                bool projectLeaderStat = checkBoxProjectLeader.Checked;
                if (name != "")
                {
                    ModifyItemCallback(uuid, name, projectLeaderStat);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void checkBoxProjectLeader_CheckedChanged(object sender, EventArgs e)
        {
            if (_qualified == true)
            {
                if (checkBoxProjectLeader.Checked == true)
                {
                    this._oneRole.ProjectLeader = true;
                }
                else
                {
                    this._oneRole.ProjectLeader = false;
                }
            }
            else
            {
                if (checkBoxProjectLeader.Checked == true)
                {
                    MessageBox.Show("This role is not qualified to be a project leader");
                    checkBoxProjectLeader.Checked = false;
                    this._oneRole.ProjectLeader = false;
                }
            }
        }
    }
}
