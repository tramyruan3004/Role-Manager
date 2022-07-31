namespace ExperimentTreeViewV2
{
    partial class FormManageRoles
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxProjectLeader = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxUUID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxRoleName = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxConsole = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonExpandAll = new System.Windows.Forms.Button();
            this.buttonCollapseAll = new System.Windows.Forms.Button();
            this.treeViewRole = new System.Windows.Forms.TreeView();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkBoxProjectLeader);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textboxUUID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textboxRoleName);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(26, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 284);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(198, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Read-only";
            // 
            // checkBoxProjectLeader
            // 
            this.checkBoxProjectLeader.AutoSize = true;
            this.checkBoxProjectLeader.Enabled = false;
            this.checkBoxProjectLeader.Location = new System.Drawing.Point(59, 179);
            this.checkBoxProjectLeader.Name = "checkBoxProjectLeader";
            this.checkBoxProjectLeader.Size = new System.Drawing.Size(211, 29);
            this.checkBoxProjectLeader.TabIndex = 10;
            this.checkBoxProjectLeader.Text = "Project Leader Role?";
            this.checkBoxProjectLeader.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selected Role Node Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Role UUID";
            // 
            // textboxUUID
            // 
            this.textboxUUID.Enabled = false;
            this.textboxUUID.Location = new System.Drawing.Point(162, 87);
            this.textboxUUID.Name = "textboxUUID";
            this.textboxUUID.Size = new System.Drawing.Size(273, 31);
            this.textboxUUID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Role name";
            // 
            // textboxRoleName
            // 
            this.textboxRoleName.Enabled = false;
            this.textboxRoleName.Location = new System.Drawing.Point(162, 124);
            this.textboxRoleName.Name = "textboxRoleName";
            this.textboxRoleName.Size = new System.Drawing.Size(273, 31);
            this.textboxRoleName.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonReset.Location = new System.Drawing.Point(26, 337);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(154, 34);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonLoad.Location = new System.Drawing.Point(364, 337);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(154, 34);
            this.buttonLoad.TabIndex = 8;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonSave.Location = new System.Drawing.Point(194, 337);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(154, 34);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Console";
            // 
            // textboxConsole
            // 
            this.textboxConsole.Location = new System.Drawing.Point(26, 436);
            this.textboxConsole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxConsole.Multiline = true;
            this.textboxConsole.Name = "textboxConsole";
            this.textboxConsole.Size = new System.Drawing.Size(492, 297);
            this.textboxConsole.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(565, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Role Node Tree View";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(565, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(513, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Right click to perform actions such as edit, remove or add roles";
            // 
            // buttonExpandAll
            // 
            this.buttonExpandAll.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonExpandAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExpandAll.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonExpandAll.Location = new System.Drawing.Point(1128, 41);
            this.buttonExpandAll.Name = "buttonExpandAll";
            this.buttonExpandAll.Size = new System.Drawing.Size(154, 34);
            this.buttonExpandAll.TabIndex = 16;
            this.buttonExpandAll.Text = "Expand All";
            this.buttonExpandAll.UseVisualStyleBackColor = false;
            this.buttonExpandAll.Click += new System.EventHandler(this.buttonExpandAll_Click);
            // 
            // buttonCollapseAll
            // 
            this.buttonCollapseAll.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCollapseAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCollapseAll.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonCollapseAll.Location = new System.Drawing.Point(1306, 41);
            this.buttonCollapseAll.Name = "buttonCollapseAll";
            this.buttonCollapseAll.Size = new System.Drawing.Size(154, 34);
            this.buttonCollapseAll.TabIndex = 17;
            this.buttonCollapseAll.Text = "Collapse All";
            this.buttonCollapseAll.UseVisualStyleBackColor = false;
            this.buttonCollapseAll.Click += new System.EventHandler(this.buttonCollapseAll_Click);
            // 
            // treeViewRole
            // 
            this.treeViewRole.Location = new System.Drawing.Point(565, 122);
            this.treeViewRole.Name = "treeViewRole";
            this.treeViewRole.Size = new System.Drawing.Size(895, 611);
            this.treeViewRole.TabIndex = 18;
            // 
            // FormManageRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1489, 765);
            this.Controls.Add(this.treeViewRole);
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
            this.Name = "FormManageRoles";
            this.Text = "Manage_Roles";
            this.Load += new System.EventHandler(this.FormManageRoles_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxUUID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxRoleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxProjectLeader;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxConsole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonExpandAll;
        private System.Windows.Forms.Button buttonCollapseAll;
        private System.Windows.Forms.TreeView treeViewRole;
    }
}