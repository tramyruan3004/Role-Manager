namespace ExperimentTreeViewV2
{
    partial class FormAddEmployee
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxReportingOff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxNodeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxNodeSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.checkBoxDummy = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(195, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Add New Employee";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonCancel.Location = new System.Drawing.Point(296, 268);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(171, 34);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonAdd.Location = new System.Drawing.Point(91, 268);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(171, 34);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Reporting Officier";
            // 
            // textboxReportingOff
            // 
            this.textboxReportingOff.Enabled = false;
            this.textboxReportingOff.Location = new System.Drawing.Point(231, 66);
            this.textboxReportingOff.Name = "textboxReportingOff";
            this.textboxReportingOff.Size = new System.Drawing.Size(273, 31);
            this.textboxReportingOff.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // textboxNodeName
            // 
            this.textboxNodeName.Location = new System.Drawing.Point(231, 107);
            this.textboxNodeName.Name = "textboxNodeName";
            this.textboxNodeName.Size = new System.Drawing.Size(273, 31);
            this.textboxNodeName.TabIndex = 19;
            this.textboxNodeName.TextChanged += new System.EventHandler(this.textboxNodeName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Salary (S$)";
            // 
            // textboxNodeSalary
            // 
            this.textboxNodeSalary.Location = new System.Drawing.Point(231, 149);
            this.textboxNodeSalary.Name = "textboxNodeSalary";
            this.textboxNodeSalary.Size = new System.Drawing.Size(273, 31);
            this.textboxNodeSalary.TabIndex = 26;
            this.textboxNodeSalary.TextChanged += new System.EventHandler(this.textboxNodeSalary_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Role";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(231, 192);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(273, 33);
            this.comboBoxRoles.TabIndex = 30;
            this.comboBoxRoles.Text = "Select the role";
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged);
            // 
            // checkBoxDummy
            // 
            this.checkBoxDummy.AutoSize = true;
            this.checkBoxDummy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDummy.Location = new System.Drawing.Point(63, 233);
            this.checkBoxDummy.Name = "checkBoxDummy";
            this.checkBoxDummy.Size = new System.Drawing.Size(176, 29);
            this.checkBoxDummy.TabIndex = 31;
            this.checkBoxDummy.Text = "Dummy Account?";
            this.checkBoxDummy.UseVisualStyleBackColor = true;
            this.checkBoxDummy.CheckedChanged += new System.EventHandler(this.checkBoxDummy_CheckedChanged);
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 330);
            this.Controls.Add(this.checkBoxDummy);
            this.Controls.Add(this.comboBoxRoles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxNodeSalary);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxReportingOff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxNodeName);
            this.Controls.Add(this.label3);
            this.Name = "FormAddEmployee";
            this.Text = "Add_New_Employee";
            this.Load += new System.EventHandler(this.FormAddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxReportingOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxNodeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxNodeSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.CheckBox checkBoxDummy;
    }
}