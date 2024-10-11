﻿
namespace NoteAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelShowCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonDeleteNote = new System.Windows.Forms.Button();
            this.buttonEditNote = new System.Windows.Forms.Button();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCategoryLabel = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelCreatedLabel = new System.Windows.Forms.Label();
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.labelModifiedLabel = new System.Windows.Forms.Label();
            this.dateTimePickerModified = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listViewNotes = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Enabled = false;
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Enabled = false;
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelShowCategory
            // 
            this.labelShowCategory.AutoSize = true;
            this.labelShowCategory.Location = new System.Drawing.Point(9, 32);
            this.labelShowCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShowCategory.Name = "labelShowCategory";
            this.labelShowCategory.Size = new System.Drawing.Size(81, 13);
            this.labelShowCategory.TabIndex = 1;
            this.labelShowCategory.Text = "Show category:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(92, 32);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(153, 21);
            this.comboBoxCategory.TabIndex = 2;
            // 
            // buttonDeleteNote
            // 
            this.buttonDeleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteNote.BackgroundImage = global::NoteAppUI.Properties.Resources.ImageNoteDelete32;
            this.buttonDeleteNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteNote.Enabled = false;
            this.buttonDeleteNote.Location = new System.Drawing.Point(78, 410);
            this.buttonDeleteNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteNote.Name = "buttonDeleteNote";
            this.buttonDeleteNote.Size = new System.Drawing.Size(30, 32);
            this.buttonDeleteNote.TabIndex = 6;
            this.buttonDeleteNote.UseVisualStyleBackColor = true;
            // 
            // buttonEditNote
            // 
            this.buttonEditNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditNote.BackgroundImage = global::NoteAppUI.Properties.Resources.ImageNoteEdit32;
            this.buttonEditNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditNote.Enabled = false;
            this.buttonEditNote.Location = new System.Drawing.Point(44, 410);
            this.buttonEditNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditNote.Name = "buttonEditNote";
            this.buttonEditNote.Size = new System.Drawing.Size(30, 32);
            this.buttonEditNote.TabIndex = 5;
            this.buttonEditNote.UseVisualStyleBackColor = true;
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddNote.BackgroundImage = global::NoteAppUI.Properties.Resources.ImageNoteAdd32;
            this.buttonAddNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddNote.Location = new System.Drawing.Point(9, 410);
            this.buttonAddNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(30, 32);
            this.buttonAddNote.TabIndex = 4;
            this.buttonAddNote.UseVisualStyleBackColor = true;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(249, 31);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(217, 26);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Название заметки";
            // 
            // labelCategoryLabel
            // 
            this.labelCategoryLabel.AutoSize = true;
            this.labelCategoryLabel.Location = new System.Drawing.Point(251, 57);
            this.labelCategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoryLabel.Name = "labelCategoryLabel";
            this.labelCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.labelCategoryLabel.TabIndex = 8;
            this.labelCategoryLabel.Text = "Category:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(308, 57);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(112, 13);
            this.labelCategory.TabIndex = 9;
            this.labelCategory.Text = "Название категории";
            // 
            // labelCreatedLabel
            // 
            this.labelCreatedLabel.AutoSize = true;
            this.labelCreatedLabel.Location = new System.Drawing.Point(251, 82);
            this.labelCreatedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreatedLabel.Name = "labelCreatedLabel";
            this.labelCreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.labelCreatedLabel.TabIndex = 10;
            this.labelCreatedLabel.Text = "Created:";
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Enabled = false;
            this.dateTimePickerCreated.Location = new System.Drawing.Point(302, 78);
            this.dateTimePickerCreated.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerCreated.TabIndex = 11;
            // 
            // labelModifiedLabel
            // 
            this.labelModifiedLabel.AutoSize = true;
            this.labelModifiedLabel.Location = new System.Drawing.Point(457, 82);
            this.labelModifiedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModifiedLabel.Name = "labelModifiedLabel";
            this.labelModifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.labelModifiedLabel.TabIndex = 12;
            this.labelModifiedLabel.Text = "Modified:";
            // 
            // dateTimePickerModified
            // 
            this.dateTimePickerModified.Enabled = false;
            this.dateTimePickerModified.Location = new System.Drawing.Point(510, 78);
            this.dateTimePickerModified.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerModified.Name = "dateTimePickerModified";
            this.dateTimePickerModified.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerModified.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(254, 101);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(477, 342);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // listViewNotes
            // 
            this.listViewNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewNotes.HideSelection = false;
            this.listViewNotes.Location = new System.Drawing.Point(9, 58);
            this.listViewNotes.MultiSelect = false;
            this.listViewNotes.Name = "listViewNotes";
            this.listViewNotes.Size = new System.Drawing.Size(236, 347);
            this.listViewNotes.TabIndex = 15;
            this.listViewNotes.UseCompatibleStateImageBehavior = false;
            this.listViewNotes.View = System.Windows.Forms.View.List;
            this.listViewNotes.SelectedIndexChanged += new System.EventHandler(this.listViewNotes_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.listViewNotes);
            this.Controls.Add(this.buttonDeleteNote);
            this.Controls.Add(this.buttonEditNote);
            this.Controls.Add(this.buttonAddNote);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelShowCategory);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePickerModified);
            this.Controls.Add(this.labelModifiedLabel);
            this.Controls.Add(this.dateTimePickerCreated);
            this.Controls.Add(this.labelCreatedLabel);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelCategoryLabel);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(686, 422);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelShowCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonAddNote;
        private System.Windows.Forms.Button buttonEditNote;
        private System.Windows.Forms.Button buttonDeleteNote;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategoryLabel;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelCreatedLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
        private System.Windows.Forms.Label labelModifiedLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerModified;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView listViewNotes;
    }
}

