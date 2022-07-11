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
        public delegate void ModifyItemDelegate(string uuid, string roleName);
        public ModifyItemDelegate ModifyItemCallback;
        public FormUpdateRole()
        {
            InitializeComponent();
        }
        //need a constructor which can receive role name input
        public FormUpdateRole(string uuid, string roleName)
        {

            InitializeComponent();
            this._oneRole = new Role();
            this._oneRole.Name = roleName;
            this._oneRole.UUID = uuid;
        }
        private void FormUpdateRole_Load(object sender, EventArgs e)
        {
            this.textboxRoleName.Text = _oneRole.Name;
            this.textboxUUID.Text = _oneRole.UUID;
        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            string name = textboxRoleName.Text.Trim();
            string uuid = textboxUUID.Text.Trim();
            if (name != "")
            {
                ModifyItemCallback(uuid,name);
                this.DialogResult = DialogResult.OK;

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
