namespace ExperimentTreeViewV2
{
    partial class FormManageEmployee
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
            this.treeViewEmployee = new System.Windows.Forms.TreeView();
            this.buttonCollapseAll = new System.Windows.Forms.Button();
            this.buttonExpandAll = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxConsole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxDummy = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEmployeeRole = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxUUID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxReportingOff = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewEmployee
            // 
            this.treeViewEmployee.Location = new System.Drawing.Point(566, 122);
            this.treeViewEmployee.Name = "treeViewEmployee";
            this.treeViewEmployee.Size = new System.Drawing.Size(895, 611);
            this.treeViewEmployee.TabIndex = 29;
            // 
            // buttonCollapseAll
            // 
            this.buttonCollapseAll.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCollapseAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCollapseAll.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonCollapseAll.Location = new System.Drawing.Point(1307, 41);
            this.buttonCollapseAll.Name = "buttonCollapseAll";
            this.buttonCollapseAll.Size = new System.Drawing.Size(154, 34);
            this.buttonCollapseAll.TabIndex = 28;
            this.buttonCollapseAll.Text = "Collapse All";
            this.buttonCollapseAll.UseVisualStyleBackColor = false;
            this.buttonCollapseAll.Click += new System.EventHandler(this.buttonCollapseAll_Click);
            // 
            // buttonExpandAll
            // 
            this.buttonExpandAll.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonExpandAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExpandAll.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonExpandAll.Location = new System.Drawing.Point(1129, 41);
            this.buttonExpandAll.Name = "buttonExpandAll";
            this.buttonExpandAll.Size = new System.Drawing.Size(154, 34);
            this.buttonExpandAll.TabIndex = 27;
            this.buttonExpandAll.Text = "Expand All";
            this.buttonExpandAll.UseVisualStyleBackColor = false;
            this.buttonExpandAll.Click += new System.EventHandler(this.buttonExpandAll_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(561, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Right click to perform actions such as edit, remove or add employees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(566, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Employee Node Tree View";
            // 
            // textboxConsole
            // 
            this.textboxConsole.Location = new System.Drawing.Point(27, 555);
            this.textboxConsole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxConsole.Multiline = true;
            this.textboxConsole.Name = "textboxConsole";
            this.textboxConsole.Size = new System.Drawing.Size(492, 178);
            this.textboxConsole.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Console";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonSave.Location = new System.Drawing.Point(195, 470);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(154, 34);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonLoad.Location = new System.Drawing.Point(365, 470);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(154, 34);
            this.buttonLoad.TabIndex = 21;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonReset.Location = new System.Drawing.Point(27, 470);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(154, 34);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxDummy);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxProject);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxEmployeeRole);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxEmployeeName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxSalary);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textboxUUID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textboxReportingOff);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(27, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 417);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // checkBoxDummy
            // 
            this.checkBoxDummy.AutoSize = true;
            this.checkBoxDummy.Enabled = false;
            this.checkBoxDummy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDummy.Location = new System.Drawing.Point(37, 329);
            this.checkBoxDummy.Name = "checkBoxDummy";
            this.checkBoxDummy.Size = new System.Drawing.Size(176, 29);
            this.checkBoxDummy.TabIndex = 20;
            this.checkBoxDummy.Text = "Dummy Account?";
            this.checkBoxDummy.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Projects";
            // 
            // textBoxProject
            // 
            this.textBoxProject.Enabled = false;
            this.textBoxProject.Location = new System.Drawing.Point(227, 289);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(231, 31);
            this.textBoxProject.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Role";
            // 
            // textBoxEmployeeRole
            // 
            this.textBoxEmployeeRole.Enabled = false;
            this.textBoxEmployeeRole.Location = new System.Drawing.Point(228, 246);
            this.textBoxEmployeeRole.Name = "textBoxEmployeeRole";
            this.textBoxEmployeeRole.Size = new System.Drawing.Size(230, 31);
            this.textBoxEmployeeRole.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Name";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Enabled = false;
            this.textBoxEmployeeName.Location = new System.Drawing.Point(227, 162);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(230, 31);
            this.textBoxEmployeeName.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Salary (S$)";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Enabled = false;
            this.textBoxSalary.Location = new System.Drawing.Point(227, 204);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(230, 31);
            this.textBoxSalary.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(189, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Read-only";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selected Employee Node Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "UUID";
            // 
            // textboxUUID
            // 
            this.textboxUUID.Enabled = false;
            this.textboxUUID.Location = new System.Drawing.Point(227, 83);
            this.textboxUUID.Name = "textboxUUID";
            this.textboxUUID.Size = new System.Drawing.Size(230, 31);
            this.textboxUUID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reporting Officer";
            // 
            // textboxReportingOff
            // 
            this.textboxReportingOff.Enabled = false;
            this.textboxReportingOff.Location = new System.Drawing.Point(227, 122);
            this.textboxReportingOff.Name = "textboxReportingOff";
            this.textboxReportingOff.Size = new System.Drawing.Size(230, 31);
            this.textboxReportingOff.TabIndex = 0;
            // 
            // FormManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 765);
            this.Controls.Add(this.treeViewEmployee);
            this.Controls.Add(this.buttonCollapseAll);
            this.Controls.Add(this.buttonExpandAll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textboxConsole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormManageEmployee";
            this.Text = "Manage_Employee";
            this.Load += new System.EventHandler(this.FormManageEmployee_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewEmployee;
        private System.Windows.Forms.Button buttonCollapseAll;
        private System.Windows.Forms.Button buttonExpandAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxConsole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxUUID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxReportingOff;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxProject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEmployeeRole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.CheckBox checkBoxDummy;
    }
}