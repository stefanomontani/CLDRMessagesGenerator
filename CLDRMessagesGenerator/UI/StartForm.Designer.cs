namespace Com.AzureSeed.CLDRMessagesGenerator.UI
{
    partial class StartForm
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
            this.txtMessagesFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectMessagesFolder = new System.Windows.Forms.Button();
            this.btnOpenMessagesArchive = new System.Windows.Forms.Button();
            this.btnCreateMessagesArchive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessagesFolder
            // 
            this.txtMessagesFolder.Location = new System.Drawing.Point(106, 10);
            this.txtMessagesFolder.Name = "txtMessagesFolder";
            this.txtMessagesFolder.Size = new System.Drawing.Size(308, 20);
            this.txtMessagesFolder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Messages Folder";
            // 
            // btnSelectMessagesFolder
            // 
            this.btnSelectMessagesFolder.Location = new System.Drawing.Point(420, 8);
            this.btnSelectMessagesFolder.Name = "btnSelectMessagesFolder";
            this.btnSelectMessagesFolder.Size = new System.Drawing.Size(34, 23);
            this.btnSelectMessagesFolder.TabIndex = 2;
            this.btnSelectMessagesFolder.Text = "...";
            this.btnSelectMessagesFolder.UseVisualStyleBackColor = true;
            // 
            // btnOpenMessagesArchive
            // 
            this.btnOpenMessagesArchive.Location = new System.Drawing.Point(106, 36);
            this.btnOpenMessagesArchive.Name = "btnOpenMessagesArchive";
            this.btnOpenMessagesArchive.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMessagesArchive.TabIndex = 3;
            this.btnOpenMessagesArchive.Text = "Open";
            this.btnOpenMessagesArchive.UseVisualStyleBackColor = true;
            this.btnOpenMessagesArchive.Click += new System.EventHandler(this.btnOpenMessagesArchive_Click);
            // 
            // btnCreateMessagesArchive
            // 
            this.btnCreateMessagesArchive.Location = new System.Drawing.Point(187, 36);
            this.btnCreateMessagesArchive.Name = "btnCreateMessagesArchive";
            this.btnCreateMessagesArchive.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMessagesArchive.TabIndex = 3;
            this.btnCreateMessagesArchive.Text = "Create";
            this.btnCreateMessagesArchive.UseVisualStyleBackColor = true;
            this.btnCreateMessagesArchive.Click += new System.EventHandler(this.btnCreateMessagesArchive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 78);
            this.Controls.Add(this.btnCreateMessagesArchive);
            this.Controls.Add(this.btnOpenMessagesArchive);
            this.Controls.Add(this.btnSelectMessagesFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessagesFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLDR Messages Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessagesFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectMessagesFolder;
        private System.Windows.Forms.Button btnOpenMessagesArchive;
        private System.Windows.Forms.Button btnCreateMessagesArchive;
    }
}

