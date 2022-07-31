namespace ExperimentTreeViewV2
{
    partial class FormManageProjects
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCollapseAll = new System.Windows.Forms.Button();
            this.buttonExpandAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.treeViewEmployee = new System.Windows.Forms.TreeView();
            this.groupBoxAddProj = new System.Windows.Forms.GroupBox();
            this.buttonConfirmAdd = new System.Windows.Forms.Button();
            this.buttonCancelAdd = new System.Windows.Forms.Button();
            this.buttonSearchForTeamAdd = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTeamLeaderAdd = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRevenueAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxProjNameAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxEditProj = new System.Windows.Forms.GroupBox();
            this.buttonConfirmEdit = new System.Windows.Forms.Button();
            this.buttonDeleteProjEdit = new System.Windows.Forms.Button();
            this.buttonSearchForTeamEdit = new System.Windows.Forms.Button();
            this.comboBoxTeamLeaderEdit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxRevenueEdit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxProjUUIDEdit = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxProjNameEdit = new System.Windows.Forms.TextBox();
            this.textboxConsole = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listViewProj = new System.Windows.Forms.ListView();
            this.columnHeaderUUID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderProjName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderRevenue = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTeamLeader = new System.Windows.Forms.ColumnHeader();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.groupBoxAddProj.SuspendLayout();
            this.groupBoxEditProj.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonSave.Location = new System.Drawing.Point(218, 22);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(164, 39);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonLoad.Location = new System.Drawing.Point(415, 22);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(164, 39);
            this.buttonLoad.TabIndex = 24;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonReset.Location = new System.Drawing.Point(24, 22);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(164, 39);
            this.buttonReset.TabIndex = 23;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            // 
            // buttonCollapseAll
            // 
            this.buttonCollapseAll.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCollapseAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCollapseAll.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonCollapseAll.Location = new System.Drawing.Point(425, 71);
            this.buttonCollapseAll.Name = "buttonCollapseAll";
            this.buttonCollapseAll.Size = new System.Drawing.Size(154, 34);
            this.buttonCollapseAll.TabIndex = 31;
            this.buttonCollapseAll.Text = "Collapse All";
            this.buttonCollapseAll.UseVisualStyleBackColor = false;
            this.buttonCollapseAll.Click += new System.EventHandler(this.buttonCollapseAll_Click);
            // 
            // buttonExpandAll
            // 
            this.buttonExpandAll.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonExpandAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExpandAll.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonExpandAll.Location = new System.Drawing.Point(247, 71);
            this.buttonExpandAll.Name = "buttonExpandAll";
            this.buttonExpandAll.Size = new System.Drawing.Size(154, 34);
            this.buttonExpandAll.TabIndex = 30;
            this.buttonExpandAll.Text = "Expand All";
            this.buttonExpandAll.UseVisualStyleBackColor = false;
            this.buttonExpandAll.Click += new System.EventHandler(this.buttonExpandAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Employee Tree View";
            // 
            // treeViewEmployee
            // 
            this.treeViewEmployee.Location = new System.Drawing.Point(24, 115);
            this.treeViewEmployee.Name = "treeViewEmployee";
            this.treeViewEmployee.Size = new System.Drawing.Size(678, 626);
            this.treeViewEmployee.TabIndex = 32;
            // 
            // groupBoxAddProj
            // 
            this.groupBoxAddProj.Controls.Add(this.buttonConfirmAdd);
            this.groupBoxAddProj.Controls.Add(this.buttonCancelAdd);
            this.groupBoxAddProj.Controls.Add(this.buttonSearchForTeamAdd);
            this.groupBoxAddProj.Controls.Add(this.label20);
            this.groupBoxAddProj.Controls.Add(this.label19);
            this.groupBoxAddProj.Controls.Add(this.label9);
            this.groupBoxAddProj.Controls.Add(this.label4);
            this.groupBoxAddProj.Controls.Add(this.label2);
            this.groupBoxAddProj.Controls.Add(this.label1);
            this.groupBoxAddProj.Controls.Add(this.comboBoxTeamLeaderAdd);
            this.groupBoxAddProj.Controls.Add(this.label11);
            this.groupBoxAddProj.Controls.Add(this.label10);
            this.groupBoxAddProj.Controls.Add(this.textBoxRevenueAdd);
            this.groupBoxAddProj.Controls.Add(this.label8);
            this.groupBoxAddProj.Controls.Add(this.textBoxProjNameAdd);
            this.groupBoxAddProj.Controls.Add(this.label3);
            this.groupBoxAddProj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAddProj.Location = new System.Drawing.Point(724, 103);
            this.groupBoxAddProj.Name = "groupBoxAddProj";
            this.groupBoxAddProj.Size = new System.Drawing.Size(553, 406);
            this.groupBoxAddProj.TabIndex = 33;
            this.groupBoxAddProj.TabStop = false;
            // 
            // buttonConfirmAdd
            // 
            this.buttonConfirmAdd.AccessibleName = "";
            this.buttonConfirmAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonConfirmAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmAdd.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonConfirmAdd.Location = new System.Drawing.Point(355, 349);
            this.buttonConfirmAdd.Name = "buttonConfirmAdd";
            this.buttonConfirmAdd.Size = new System.Drawing.Size(171, 39);
            this.buttonConfirmAdd.TabIndex = 50;
            this.buttonConfirmAdd.Text = "Confirm Add";
            this.buttonConfirmAdd.UseVisualStyleBackColor = false;
            this.buttonConfirmAdd.Click += new System.EventHandler(this.buttonConfirmAdd_Click);
            // 
            // buttonCancelAdd
            // 
            this.buttonCancelAdd.AccessibleName = "";
            this.buttonCancelAdd.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancelAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelAdd.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonCancelAdd.Location = new System.Drawing.Point(211, 349);
            this.buttonCancelAdd.Name = "buttonCancelAdd";
            this.buttonCancelAdd.Size = new System.Drawing.Size(135, 39);
            this.buttonCancelAdd.TabIndex = 49;
            this.buttonCancelAdd.Text = "Cancel";
            this.buttonCancelAdd.UseVisualStyleBackColor = false;
            this.buttonCancelAdd.Click += new System.EventHandler(this.buttonCancelAdd_Click);
            // 
            // buttonSearchForTeamAdd
            // 
            this.buttonSearchForTeamAdd.AccessibleName = "";
            this.buttonSearchForTeamAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonSearchForTeamAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearchForTeamAdd.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonSearchForTeamAdd.Location = new System.Drawing.Point(24, 349);
            this.buttonSearchForTeamAdd.Name = "buttonSearchForTeamAdd";
            this.buttonSearchForTeamAdd.Size = new System.Drawing.Size(179, 39);
            this.buttonSearchForTeamAdd.TabIndex = 48;
            this.buttonSearchForTeamAdd.Text = "Search for Teams";
            this.buttonSearchForTeamAdd.UseVisualStyleBackColor = false;
            this.buttonSearchForTeamAdd.Click += new System.EventHandler(this.buttonSearchForTeamAdd_Click);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(113, 171);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(424, 26);
            this.label20.TabIndex = 47;
            this.label20.Text = "Click the \"Confirm Add\" button";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(113, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(424, 53);
            this.label19.TabIndex = 46;
            this.label19.Text = "Select team leader via the dropdown (Highlighted in Employee Tree View)";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(113, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(424, 53);
            this.label9.TabIndex = 45;
            this.label9.Text = "Enter project name and revenue, then click on the \"Search for Teams\" button";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Step 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Step 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Step 1:";
            // 
            // comboBoxTeamLeaderAdd
            // 
            this.comboBoxTeamLeaderAdd.AccessibleName = "";
            this.comboBoxTeamLeaderAdd.FormattingEnabled = true;
            this.comboBoxTeamLeaderAdd.Location = new System.Drawing.Point(175, 299);
            this.comboBoxTeamLeaderAdd.Name = "comboBoxTeamLeaderAdd";
            this.comboBoxTeamLeaderAdd.Size = new System.Drawing.Size(351, 33);
            this.comboBoxTeamLeaderAdd.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Team Leader";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Revenue (S$)";
            // 
            // textBoxRevenueAdd
            // 
            this.textBoxRevenueAdd.AccessibleName = "";
            this.textBoxRevenueAdd.Location = new System.Drawing.Point(175, 260);
            this.textBoxRevenueAdd.Name = "textBoxRevenueAdd";
            this.textBoxRevenueAdd.Size = new System.Drawing.Size(351, 31);
            this.textBoxRevenueAdd.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Project Name";
            // 
            // textBoxProjNameAdd
            // 
            this.textBoxProjNameAdd.AccessibleName = "";
            this.textBoxProjNameAdd.Location = new System.Drawing.Point(175, 220);
            this.textBoxProjNameAdd.Name = "textBoxProjNameAdd";
            this.textBoxProjNameAdd.Size = new System.Drawing.Size(351, 31);
            this.textBoxProjNameAdd.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Add New Project";
            // 
            // groupBoxEditProj
            // 
            this.groupBoxEditProj.Controls.Add(this.buttonConfirmEdit);
            this.groupBoxEditProj.Controls.Add(this.buttonDeleteProjEdit);
            this.groupBoxEditProj.Controls.Add(this.buttonSearchForTeamEdit);
            this.groupBoxEditProj.Controls.Add(this.comboBoxTeamLeaderEdit);
            this.groupBoxEditProj.Controls.Add(this.label5);
            this.groupBoxEditProj.Controls.Add(this.label12);
            this.groupBoxEditProj.Controls.Add(this.textBoxRevenueEdit);
            this.groupBoxEditProj.Controls.Add(this.label15);
            this.groupBoxEditProj.Controls.Add(this.label16);
            this.groupBoxEditProj.Controls.Add(this.textBoxProjUUIDEdit);
            this.groupBoxEditProj.Controls.Add(this.label17);
            this.groupBoxEditProj.Controls.Add(this.textBoxProjNameEdit);
            this.groupBoxEditProj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEditProj.Location = new System.Drawing.Point(1301, 103);
            this.groupBoxEditProj.Name = "groupBoxEditProj";
            this.groupBoxEditProj.Size = new System.Drawing.Size(553, 314);
            this.groupBoxEditProj.TabIndex = 34;
            this.groupBoxEditProj.TabStop = false;
            // 
            // buttonConfirmEdit
            // 
            this.buttonConfirmEdit.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonConfirmEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmEdit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonConfirmEdit.Location = new System.Drawing.Point(214, 253);
            this.buttonConfirmEdit.Name = "buttonConfirmEdit";
            this.buttonConfirmEdit.Size = new System.Drawing.Size(171, 39);
            this.buttonConfirmEdit.TabIndex = 53;
            this.buttonConfirmEdit.Text = "Confirm Edit";
            this.buttonConfirmEdit.UseVisualStyleBackColor = false;
            this.buttonConfirmEdit.Click += new System.EventHandler(this.buttonConfirmEdit_Click);
            // 
            // buttonDeleteProjEdit
            // 
            this.buttonDeleteProjEdit.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteProjEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteProjEdit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonDeleteProjEdit.Location = new System.Drawing.Point(394, 253);
            this.buttonDeleteProjEdit.Name = "buttonDeleteProjEdit";
            this.buttonDeleteProjEdit.Size = new System.Drawing.Size(135, 39);
            this.buttonDeleteProjEdit.TabIndex = 52;
            this.buttonDeleteProjEdit.Text = "Delete";
            this.buttonDeleteProjEdit.UseVisualStyleBackColor = false;
            this.buttonDeleteProjEdit.Click += new System.EventHandler(this.buttonDeleteProjEdit_Click);
            // 
            // buttonSearchForTeamEdit
            // 
            this.buttonSearchForTeamEdit.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonSearchForTeamEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearchForTeamEdit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonSearchForTeamEdit.Location = new System.Drawing.Point(27, 253);
            this.buttonSearchForTeamEdit.Name = "buttonSearchForTeamEdit";
            this.buttonSearchForTeamEdit.Size = new System.Drawing.Size(179, 39);
            this.buttonSearchForTeamEdit.TabIndex = 51;
            this.buttonSearchForTeamEdit.Text = "Search for Teams";
            this.buttonSearchForTeamEdit.UseVisualStyleBackColor = false;
            this.buttonSearchForTeamEdit.Click += new System.EventHandler(this.buttonSearchForTeamEdit_Click);
            // 
            // comboBoxTeamLeaderEdit
            // 
            this.comboBoxTeamLeaderEdit.FormattingEnabled = true;
            this.comboBoxTeamLeaderEdit.Location = new System.Drawing.Point(178, 197);
            this.comboBoxTeamLeaderEdit.Name = "comboBoxTeamLeaderEdit";
            this.comboBoxTeamLeaderEdit.Size = new System.Drawing.Size(351, 33);
            this.comboBoxTeamLeaderEdit.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Team Leader";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Revenue (S$)";
            // 
            // textBoxRevenueEdit
            // 
            this.textBoxRevenueEdit.Location = new System.Drawing.Point(178, 154);
            this.textBoxRevenueEdit.Name = "textBoxRevenueEdit";
            this.textBoxRevenueEdit.Size = new System.Drawing.Size(351, 31);
            this.textBoxRevenueEdit.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(202, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "View/Edit Project";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 25);
            this.label16.TabIndex = 8;
            this.label16.Text = "UUID";
            // 
            // textBoxProjUUIDEdit
            // 
            this.textBoxProjUUIDEdit.Enabled = false;
            this.textBoxProjUUIDEdit.Location = new System.Drawing.Point(178, 75);
            this.textBoxProjUUIDEdit.Name = "textBoxProjUUIDEdit";
            this.textBoxProjUUIDEdit.Size = new System.Drawing.Size(351, 31);
            this.textBoxProjUUIDEdit.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 25);
            this.label17.TabIndex = 6;
            this.label17.Text = "Project Name";
            // 
            // textBoxProjNameEdit
            // 
            this.textBoxProjNameEdit.Location = new System.Drawing.Point(178, 114);
            this.textBoxProjNameEdit.Name = "textBoxProjNameEdit";
            this.textBoxProjNameEdit.Size = new System.Drawing.Size(351, 31);
            this.textBoxProjNameEdit.TabIndex = 0;
            // 
            // textboxConsole
            // 
            this.textboxConsole.Enabled = false;
            this.textboxConsole.Location = new System.Drawing.Point(724, 551);
            this.textboxConsole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxConsole.Multiline = true;
            this.textboxConsole.Name = "textboxConsole";
            this.textboxConsole.ReadOnly = true;
            this.textboxConsole.Size = new System.Drawing.Size(553, 190);
            this.textboxConsole.TabIndex = 36;
            this.textboxConsole.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(724, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Console";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(1297, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 25);
            this.label13.TabIndex = 37;
            this.label13.Text = "Project List";
            // 
            // listViewProj
            // 
            this.listViewProj.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUUID,
            this.columnHeaderProjName,
            this.columnHeaderRevenue,
            this.columnHeaderTeamLeader});
            this.listViewProj.FullRowSelect = true;
            this.listViewProj.HideSelection = false;
            this.listViewProj.Location = new System.Drawing.Point(1301, 457);
            this.listViewProj.Name = "listViewProj";
            this.listViewProj.Size = new System.Drawing.Size(553, 284);
            this.listViewProj.TabIndex = 38;
            this.listViewProj.UseCompatibleStateImageBehavior = false;
            this.listViewProj.View = System.Windows.Forms.View.Details;
            this.listViewProj.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewProj_ItemSelectionChanged);
            // 
            // columnHeaderUUID
            // 
            this.columnHeaderUUID.Text = "UUID";
            this.columnHeaderUUID.Width = 80;
            // 
            // columnHeaderProjName
            // 
            this.columnHeaderProjName.Text = "Project Name";
            this.columnHeaderProjName.Width = 150;
            // 
            // columnHeaderRevenue
            // 
            this.columnHeaderRevenue.Text = "Revenue";
            this.columnHeaderRevenue.Width = 100;
            // 
            // columnHeaderTeamLeader
            // 
            this.columnHeaderTeamLeader.Text = "Team Leader";
            this.columnHeaderTeamLeader.Width = 120;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(1649, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 25);
            this.label18.TabIndex = 39;
            this.label18.Text = "Mode";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(1716, 47);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(135, 33);
            this.comboBoxMode.TabIndex = 40;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // FormManageProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1881, 765);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.listViewProj);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textboxConsole);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBoxEditProj);
            this.Controls.Add(this.groupBoxAddProj);
            this.Controls.Add(this.treeViewEmployee);
            this.Controls.Add(this.buttonCollapseAll);
            this.Controls.Add(this.buttonExpandAll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonReset);
            this.Name = "FormManageProjects";
            this.Text = "Manage_Projects";
            this.Load += new System.EventHandler(this.FormManageProjects_Load);
            this.groupBoxAddProj.ResumeLayout(false);
            this.groupBoxAddProj.PerformLayout();
            this.groupBoxEditProj.ResumeLayout(false);
            this.groupBoxEditProj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCollapseAll;
        private System.Windows.Forms.Button buttonExpandAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeViewEmployee;
        private System.Windows.Forms.GroupBox groupBoxAddProj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRevenueAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxProjNameAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxEditProj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxRevenueEdit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxProjUUIDEdit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxProjNameEdit;
        private System.Windows.Forms.TextBox textboxConsole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listViewProj;
        private System.Windows.Forms.ColumnHeader columnHeaderUUID;
        private System.Windows.Forms.ColumnHeader columnHeaderProjName;
        private System.Windows.Forms.ColumnHeader columnHeaderRevenue;
        private System.Windows.Forms.ColumnHeader columnHeaderTeamLeader;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTeamLeaderAdd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Button buttonConfirmAdd;
        private System.Windows.Forms.Button buttonCancelAdd;
        private System.Windows.Forms.Button buttonSearchForTeamAdd;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonConfirmEdit;
        private System.Windows.Forms.Button buttonDeleteProjEdit;
        private System.Windows.Forms.Button buttonSearchForTeamEdit;
        private System.Windows.Forms.ComboBox comboBoxTeamLeaderEdit;
    }
}