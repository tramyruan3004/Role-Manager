namespace ExperimentTreeViewV2
{
    partial class FormAddSecondaryRole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxReportingOff = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUUID = new System.Windows.Forms.TextBox();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxNodeSalary = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxNodeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxDummy = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBoxReportingOff
            // 
            this.comboBoxReportingOff.FormattingEnabled = true;
            this.comboBoxReportingOff.Location = new System.Drawing.Point(229, 94);
            this.comboBoxReportingOff.Name = "comboBoxReportingOff";
            this.comboBoxReportingOff.Size = new System.Drawing.Size(273, 33);
            this.comboBoxReportingOff.TabIndex = 58;
            this.comboBoxReportingOff.Text = "Select the role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "UUID";
            // 
            // textBoxUUID
            // 
            this.textBoxUUID.Enabled = false;
            this.textBoxUUID.Location = new System.Drawing.Point(229, 57);
            this.textBoxUUID.Name = "textBoxUUID";
            this.textBoxUUID.Size = new System.Drawing.Size(273, 31);
            this.textBoxUUID.TabIndex = 56;
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(229, 205);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(273, 33);
            this.comboBoxRoles.TabIndex = 55;
            this.comboBoxRoles.Text = "Select the role";
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "Salary (S$)";
            // 
            // textboxNodeSalary
            // 
            this.textboxNodeSalary.Enabled = false;
            this.textboxNodeSalary.Location = new System.Drawing.Point(229, 167);
            this.textboxNodeSalary.Name = "textboxNodeSalary";
            this.textboxNodeSalary.Size = new System.Drawing.Size(273, 31);
            this.textboxNodeSalary.TabIndex = 52;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonCancel.Location = new System.Drawing.Point(294, 277);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(171, 34);
            this.buttonCancel.TabIndex = 51;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonAdd.Location = new System.Drawing.Point(89, 277);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(171, 34);
            this.buttonAdd.TabIndex = 50;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Reporting Officer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Name";
            // 
            // textboxNodeName
            // 
            this.textboxNodeName.Enabled = false;
            this.textboxNodeName.Location = new System.Drawing.Point(229, 132);
            this.textboxNodeName.Name = "textboxNodeName";
            this.textboxNodeName.Size = new System.Drawing.Size(273, 31);
            this.textboxNodeName.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(111, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Change Role and/ or Reporting Officer";
            // 
            // checkBoxDummy
            // 
            this.checkBoxDummy.AutoSize = true;
            this.checkBoxDummy.Enabled = false;
            this.checkBoxDummy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDummy.Location = new System.Drawing.Point(61, 242);
            this.checkBoxDummy.Name = "checkBoxDummy";
            this.checkBoxDummy.Size = new System.Drawing.Size(176, 29);
            this.checkBoxDummy.TabIndex = 59;
            this.checkBoxDummy.Text = "Dummy Account?";
            this.checkBoxDummy.UseVisualStyleBackColor = true;
            // 
            // FormAddSecondaryRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 330);
            this.Controls.Add(this.checkBoxDummy);
            this.Controls.Add(this.comboBoxReportingOff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxUUID);
            this.Controls.Add(this.comboBoxRoles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxNodeSalary);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxNodeName);
            this.Controls.Add(this.label3);
            this.Name = "FormAddSecondaryRole";
            this.Text = "Add_Secondary_Role";
            this.Load += new System.EventHandler(this.FormAddSecondaryRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxReportingOff;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxUUID;
        public System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textboxNodeSalary;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textboxNodeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxDummy;
    }
}