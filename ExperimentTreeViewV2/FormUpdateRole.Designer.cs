namespace ExperimentTreeViewV2
{
    partial class FormUpdateRole
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
            this.textboxRoleName = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textboxUUID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxParentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxProjectLeader = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textboxRoleName
            // 
            this.textboxRoleName.Location = new System.Drawing.Point(193, 119);
            this.textboxRoleName.Name = "textboxRoleName";
            this.textboxRoleName.Size = new System.Drawing.Size(273, 31);
            this.textboxRoleName.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonEdit.Location = new System.Drawing.Point(91, 254);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(171, 34);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonOkay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "UUID";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonCancel.Location = new System.Drawing.Point(295, 254);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(171, 34);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textboxUUID
            // 
            this.textboxUUID.Enabled = false;
            this.textboxUUID.Location = new System.Drawing.Point(193, 82);
            this.textboxUUID.Name = "textboxUUID";
            this.textboxUUID.Size = new System.Drawing.Size(273, 31);
            this.textboxUUID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(220, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Edit Role";
            // 
            // textBoxParentName
            // 
            this.textBoxParentName.Enabled = false;
            this.textBoxParentName.Location = new System.Drawing.Point(193, 158);
            this.textBoxParentName.Name = "textBoxParentName";
            this.textBoxParentName.Size = new System.Drawing.Size(273, 31);
            this.textBoxParentName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Parent Role";
            // 
            // checkBoxProjectLeader
            // 
            this.checkBoxProjectLeader.AutoSize = true;
            this.checkBoxProjectLeader.Location = new System.Drawing.Point(91, 207);
            this.checkBoxProjectLeader.Name = "checkBoxProjectLeader";
            this.checkBoxProjectLeader.Size = new System.Drawing.Size(196, 29);
            this.checkBoxProjectLeader.TabIndex = 19;
            this.checkBoxProjectLeader.Text = "Project Leader Role?";
            this.checkBoxProjectLeader.UseVisualStyleBackColor = true;
            this.checkBoxProjectLeader.CheckedChanged += new System.EventHandler(this.checkBoxProjectLeader_CheckedChanged);
            // 
            // FormUpdateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 330);
            this.Controls.Add(this.checkBoxProjectLeader);
            this.Controls.Add(this.textBoxParentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textboxRoleName);
            this.Controls.Add(this.textboxUUID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEdit);
            this.Name = "FormUpdateRole";
            this.Text = "Edit_Role";
            this.Load += new System.EventHandler(this.FormUpdateRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxRoleName;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxUUID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxParentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxProjectLeader;
    }
}