namespace ExperimentTreeViewV2
{
    partial class Form2
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
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.treeViewRole = new System.Windows.Forms.TreeView();
            this.textboxAnalyze = new System.Windows.Forms.TextBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(13, 17);
            this.buttonLoadFromFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(317, 77);
            this.buttonLoadFromFile.TabIndex = 13;
            this.buttonLoadFromFile.Text = "Load tree structure data from binary file";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // treeViewRole
            // 
            this.treeViewRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.treeViewRole.Location = new System.Drawing.Point(725, 17);
            this.treeViewRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeViewRole.Name = "treeViewRole";
            this.treeViewRole.Size = new System.Drawing.Size(994, 862);
            this.treeViewRole.TabIndex = 12;
            // 
            // textboxAnalyze
            // 
            this.textboxAnalyze.Location = new System.Drawing.Point(13, 237);
            this.textboxAnalyze.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxAnalyze.Multiline = true;
            this.textboxAnalyze.Name = "textboxAnalyze";
            this.textboxAnalyze.Size = new System.Drawing.Size(673, 642);
            this.textboxAnalyze.TabIndex = 11;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(13, 126);
            this.buttonSaveToFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(317, 77);
            this.buttonSaveToFile.TabIndex = 14;
            this.buttonSaveToFile.Text = "Save tree structure data to binary file";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 961);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.treeViewRole);
            this.Controls.Add(this.textboxAnalyze);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.TreeView treeViewRole;
        private System.Windows.Forms.TextBox textboxAnalyze;
        private System.Windows.Forms.Button buttonSaveToFile;
    }
}