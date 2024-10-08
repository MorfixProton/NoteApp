
namespace NoteAppUI
{
    partial class AboutForm
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
            this.labelAboutAppName = new System.Windows.Forms.Label();
            this.labelAboutVersion = new System.Windows.Forms.Label();
            this.labelAboutAuthor = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGitHub = new System.Windows.Forms.Label();
            this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAboutAppName
            // 
            this.labelAboutAppName.AutoSize = true;
            this.labelAboutAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboutAppName.Location = new System.Drawing.Point(12, 9);
            this.labelAboutAppName.Name = "labelAboutAppName";
            this.labelAboutAppName.Size = new System.Drawing.Size(133, 32);
            this.labelAboutAppName.TabIndex = 0;
            this.labelAboutAppName.Text = "NoteApp";
            // 
            // labelAboutVersion
            // 
            this.labelAboutVersion.AutoSize = true;
            this.labelAboutVersion.Location = new System.Drawing.Point(18, 45);
            this.labelAboutVersion.Name = "labelAboutVersion";
            this.labelAboutVersion.Size = new System.Drawing.Size(55, 17);
            this.labelAboutVersion.TabIndex = 1;
            this.labelAboutVersion.Text = "v. 0.0.1";
            // 
            // labelAboutAuthor
            // 
            this.labelAboutAuthor.AutoSize = true;
            this.labelAboutAuthor.Location = new System.Drawing.Point(12, 78);
            this.labelAboutAuthor.Name = "labelAboutAuthor";
            this.labelAboutAuthor.Size = new System.Drawing.Size(166, 17);
            this.labelAboutAuthor.TabIndex = 2;
            this.labelAboutAuthor.Text = "Author: Nikita Tikhomirov";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 117);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 17);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email:";
            // 
            // labelGitHub
            // 
            this.labelGitHub.AutoSize = true;
            this.labelGitHub.Location = new System.Drawing.Point(12, 138);
            this.labelGitHub.Name = "labelGitHub";
            this.labelGitHub.Size = new System.Drawing.Size(56, 17);
            this.labelGitHub.TabIndex = 4;
            this.labelGitHub.Text = "GitHub:";
            // 
            // linkLabelEmail
            // 
            this.linkLabelEmail.AutoSize = true;
            this.linkLabelEmail.Location = new System.Drawing.Point(64, 117);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(143, 17);
            this.linkLabelEmail.TabIndex = 5;
            this.linkLabelEmail.TabStop = true;
            this.linkLabelEmail.Text = "MorfixProton@mail.ru";
            this.linkLabelEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEmail_LinkClicked);
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(68, 138);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(146, 17);
            this.linkLabelGitHub.TabIndex = 6;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "MorfixProton/NoteApp";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(13, 224);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(166, 17);
            this.labelCopyright.TabIndex = 7;
            this.labelCopyright.Text = "2024 Nikita Tikhomirov ©";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.linkLabelEmail);
            this.Controls.Add(this.labelGitHub);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAboutAuthor);
            this.Controls.Add(this.labelAboutVersion);
            this.Controls.Add(this.labelAboutAppName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAboutAppName;
        private System.Windows.Forms.Label labelAboutVersion;
        private System.Windows.Forms.Label labelAboutAuthor;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGitHub;
        private System.Windows.Forms.LinkLabel linkLabelEmail;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.Label labelCopyright;
    }
}