namespace ExperimentTreeViewV2
{
    partial class FormUpdateEmployee
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
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxNodeSalary = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxReportingOff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxNodeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUUID = new System.Windows.Forms.TextBox();
            this.comboBoxReportingOff = new System.Windows.Forms.ComboBox();
            this.checkBoxDummy = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(229, 208);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(273, 33);
            this.comboBoxRoles.TabIndex = 41;
            this.comboBoxRoles.Text = "Select the role";
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Salary (S$)";
            // 
            // textboxNodeSalary
            // 
            this.textboxNodeSalary.Location = new System.Drawing.Point(229, 169);
            this.textboxNodeSalary.Name = "textboxNodeSalary";
            this.textboxNodeSalary.Size = new System.Drawing.Size(273, 31);
            this.textboxNodeSalary.TabIndex = 38;
            this.textboxNodeSalary.TextChanged += new System.EventHandler(this.textboxNodeSalary_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonCancel.Location = new System.Drawing.Point(294, 277);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(171, 34);
            this.buttonCancel.TabIndex = 37;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonEdit.Location = new System.Drawing.Point(89, 277);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(171, 34);
            this.buttonEdit.TabIndex = 36;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Reporting Officer";
            // 
            // textboxReportingOff
            // 
            this.textboxReportingOff.Enabled = false;
            this.textboxReportingOff.Location = new System.Drawing.Point(229, 93);
            this.textboxReportingOff.Name = "textboxReportingOff";
            this.textboxReportingOff.Size = new System.Drawing.Size(273, 31);
            this.textboxReportingOff.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Name";
            // 
            // textboxNodeName
            // 
            this.textboxNodeName.Location = new System.Drawing.Point(229, 132);
            this.textboxNodeName.Name = "textboxNodeName";
            this.textboxNodeName.Size = new System.Drawing.Size(273, 31);
            this.textboxNodeName.TabIndex = 32;
            this.textboxNodeName.TextChanged += new System.EventHandler(this.textboxNodeName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(180, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Edit Employee Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "UUID";
            // 
            // textBoxUUID
            // 
            this.textBoxUUID.Enabled = false;
            this.textBoxUUID.Location = new System.Drawing.Point(229, 58);
            this.textBoxUUID.Name = "textBoxUUID";
            this.textBoxUUID.Size = new System.Drawing.Size(273, 31);
            this.textBoxUUID.TabIndex = 42;
            // 
            // comboBoxReportingOff
            // 
            this.comboBoxReportingOff.Enabled = false;
            this.comboBoxReportingOff.FormattingEnabled = true;
            this.comboBoxReportingOff.Location = new System.Drawing.Point(229, 96);
            this.comboBoxReportingOff.Name = "comboBoxReportingOff";
            this.comboBoxReportingOff.Size = new System.Drawing.Size(273, 33);
            this.comboBoxReportingOff.TabIndex = 44;
            this.comboBoxReportingOff.Text = "Select the role";
            this.comboBoxReportingOff.Visible = false;
            // 
            // checkBoxDummy
            // 
            this.checkBoxDummy.AutoSize = true;
            this.checkBoxDummy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDummy.Location = new System.Drawing.Point(61, 242);
            this.checkBoxDummy.Name = "checkBoxDummy";
            this.checkBoxDummy.Size = new System.Drawing.Size(176, 29);
            this.checkBoxDummy.TabIndex = 45;
            this.checkBoxDummy.Text = "Dummy Account?";
            this.checkBoxDummy.UseVisualStyleBackColor = true;
            this.checkBoxDummy.CheckedChanged += new System.EventHandler(this.checkBoxDummy_CheckedChanged);
            // 
            // FormUpdateEmployee
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
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxReportingOff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxNodeName);
            this.Controls.Add(this.label3);
            this.Name = "FormUpdateEmployee";
            this.Text = "FormUpdateEmployee";
            this.Load += new System.EventHandler(this.FormUpdateEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textboxNodeSalary;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textboxReportingOff;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textboxNodeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxUUID;
        public System.Windows.Forms.ComboBox comboBoxReportingOff;
        private System.Windows.Forms.CheckBox checkBoxDummy;
    }
}