namespace ExperimentTreeViewV2
{
    partial class Form1
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
            this.treeViewRole = new System.Windows.Forms.TreeView();
            this.textboxAnalyze = new System.Windows.Forms.TextBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonSetupTreeStructure = new System.Windows.Forms.Button();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewRole
            // 
            this.treeViewRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.treeViewRole.Location = new System.Drawing.Point(510, 65);
            this.treeViewRole.Name = "treeViewRole";
            this.treeViewRole.Size = new System.Drawing.Size(697, 519);
            this.treeViewRole.TabIndex = 7;
            // 
            // textboxAnalyze
            // 
            this.textboxAnalyze.Location = new System.Drawing.Point(12, 197);
            this.textboxAnalyze.Multiline = true;
            this.textboxAnalyze.Name = "textboxAnalyze";
            this.textboxAnalyze.Size = new System.Drawing.Size(472, 387);
            this.textboxAnalyze.TabIndex = 6;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(12, 127);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(222, 46);
            this.buttonSaveToFile.TabIndex = 5;
            this.buttonSaveToFile.Text = "Save tree structure data to binary file";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonSetupTreeStructure
            // 
            this.buttonSetupTreeStructure.Location = new System.Drawing.Point(12, 65);
            this.buttonSetupTreeStructure.Name = "buttonSetupTreeStructure";
            this.buttonSetupTreeStructure.Size = new System.Drawing.Size(222, 46);
            this.buttonSetupTreeStructure.TabIndex = 4;
            this.buttonSetupTreeStructure.Text = "Setup fake tree structure data";
            this.buttonSetupTreeStructure.UseVisualStyleBackColor = true;
            this.buttonSetupTreeStructure.Click += new System.EventHandler(this.buttonSetupTreeStructure_Click);
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(262, 127);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(222, 46);
            this.buttonLoadFromFile.TabIndex = 8;
            this.buttonLoadFromFile.Text = "Load tree structure data from binary file";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 648);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.treeViewRole);
            this.Controls.Add(this.textboxAnalyze);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonSetupTreeStructure);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewRole;
        private System.Windows.Forms.TextBox textboxAnalyze;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonSetupTreeStructure;
        private System.Windows.Forms.Button buttonLoadFromFile;
    }
}