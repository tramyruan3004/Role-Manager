namespace ExperimentTreeViewV2
{
    partial class FormAddRole
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
            this.checkBoxProjectLeader = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxParentRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxNodeName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxProjectLeader
            // 
            this.checkBoxProjectLeader.AutoSize = true;
            this.checkBoxProjectLeader.Enabled = false;
            this.checkBoxProjectLeader.Location = new System.Drawing.Point(88, 204);
            this.checkBoxProjectLeader.Name = "checkBoxProjectLeader";
            this.checkBoxProjectLeader.Size = new System.Drawing.Size(196, 29);
            this.checkBoxProjectLeader.TabIndex = 16;
            this.checkBoxProjectLeader.Text = "Project Leader Role?";
            this.checkBoxProjectLeader.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(223, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Add Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Parent Role";
            // 
            // textboxParentRole
            // 
            this.textboxParentRole.Enabled = false;
            this.textboxParentRole.Location = new System.Drawing.Point(191, 91);
            this.textboxParentRole.Name = "textboxParentRole";
            this.textboxParentRole.Size = new System.Drawing.Size(273, 31);
            this.textboxParentRole.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // textboxNodeName
            // 
            this.textboxNodeName.Location = new System.Drawing.Point(191, 128);
            this.textboxNodeName.Name = "textboxNodeName";
            this.textboxNodeName.Size = new System.Drawing.Size(273, 31);
            this.textboxNodeName.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonAdd.Location = new System.Drawing.Point(88, 249);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(171, 34);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonCancel.Location = new System.Drawing.Point(293, 249);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(171, 34);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(83, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Edit role to assign project leader";
            // 
            // FormAddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 330);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxProjectLeader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxParentRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxNodeName);
            this.Name = "FormAddRole";
            this.Text = "Add_Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxProjectLeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxParentRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxNodeName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label4;
    }
}