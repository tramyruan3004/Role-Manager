namespace ExperimentTreeViewV2
{
    partial class FormSwapEmployee
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxSelectedNode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.textBoxUUID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textboxReportingOff = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeRole = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.treeViewEmployee = new System.Windows.Forms.TreeView();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Employee List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "You are replacing";
            // 
            // textboxSelectedNode
            // 
            this.textboxSelectedNode.Enabled = false;
            this.textboxSelectedNode.Location = new System.Drawing.Point(200, 52);
            this.textboxSelectedNode.Name = "textboxSelectedNode";
            this.textboxSelectedNode.Size = new System.Drawing.Size(273, 31);
            this.textboxSelectedNode.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select employee node to replace with:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSwap);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxProject);
            this.groupBox2.Controls.Add(this.textBoxUUID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textboxReportingOff);
            this.groupBox2.Controls.Add(this.textBoxEmployeeRole);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxEmployeeName);
            this.groupBox2.Controls.Add(this.textBoxSalary);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(648, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 537);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // buttonSwap
            // 
            this.buttonSwap.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonSwap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSwap.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonSwap.Location = new System.Drawing.Point(161, 424);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(198, 34);
            this.buttonSwap.TabIndex = 37;
            this.buttonSwap.Text = "Swap";
            this.buttonSwap.UseVisualStyleBackColor = false;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Projects";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Replace With";
            // 
            // textBoxProject
            // 
            this.textBoxProject.Enabled = false;
            this.textBoxProject.Location = new System.Drawing.Point(239, 334);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(230, 31);
            this.textBoxProject.TabIndex = 30;
            // 
            // textBoxUUID
            // 
            this.textBoxUUID.Enabled = false;
            this.textBoxUUID.Location = new System.Drawing.Point(239, 105);
            this.textBoxUUID.Name = "textBoxUUID";
            this.textBoxUUID.Size = new System.Drawing.Size(230, 31);
            this.textBoxUUID.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "Role";
            // 
            // textboxReportingOff
            // 
            this.textboxReportingOff.Enabled = false;
            this.textboxReportingOff.Location = new System.Drawing.Point(239, 150);
            this.textboxReportingOff.Name = "textboxReportingOff";
            this.textboxReportingOff.Size = new System.Drawing.Size(230, 31);
            this.textboxReportingOff.TabIndex = 20;
            // 
            // textBoxEmployeeRole
            // 
            this.textBoxEmployeeRole.Enabled = false;
            this.textBoxEmployeeRole.Location = new System.Drawing.Point(240, 287);
            this.textBoxEmployeeRole.Name = "textBoxEmployeeRole";
            this.textBoxEmployeeRole.Size = new System.Drawing.Size(230, 31);
            this.textBoxEmployeeRole.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Reporting Officer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "UUID";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Enabled = false;
            this.textBoxEmployeeName.Location = new System.Drawing.Point(239, 196);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(230, 31);
            this.textBoxEmployeeName.TabIndex = 26;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Enabled = false;
            this.textBoxSalary.Location = new System.Drawing.Point(239, 242);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(230, 31);
            this.textBoxSalary.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Salary (S$)";
            // 
            // treeViewEmployee
            // 
            this.treeViewEmployee.Location = new System.Drawing.Point(30, 141);
            this.treeViewEmployee.Name = "treeViewEmployee";
            this.treeViewEmployee.Size = new System.Drawing.Size(589, 525);
            this.treeViewEmployee.TabIndex = 19;
            // 
            // FormSwapEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 695);
            this.Controls.Add(this.treeViewEmployee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxSelectedNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "FormSwapEmployee";
            this.Text = "Replace_Employee_Form";
            this.Load += new System.EventHandler(this.FormSwapEmployee_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxSelectedNode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView treeViewEmployee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxProject;
        private System.Windows.Forms.TextBox textBoxUUID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textboxReportingOff;
        private System.Windows.Forms.TextBox textBoxEmployeeRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSwap;
    }
}