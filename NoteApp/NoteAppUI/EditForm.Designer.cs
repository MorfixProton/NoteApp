
namespace NoteAppUI
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCreated = new System.Windows.Forms.Label();
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.labelModified = new System.Windows.Forms.Label();
            this.dateTimePickerModified = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 38);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(69, 17);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Location = new System.Drawing.Point(87, 6);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(683, 22);
            this.textBoxTitle.TabIndex = 2;
            this.textBoxTitle.Text = "Без названия";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(87, 34);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(232, 24);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // labelCreated
            // 
            this.labelCreated.AutoSize = true;
            this.labelCreated.Location = new System.Drawing.Point(12, 76);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(62, 17);
            this.labelCreated.TabIndex = 4;
            this.labelCreated.Text = "Created:";
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Enabled = false;
            this.dateTimePickerCreated.Location = new System.Drawing.Point(87, 71);
            this.dateTimePickerCreated.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerCreated.TabIndex = 5;
            // 
            // labelModified
            // 
            this.labelModified.AutoSize = true;
            this.labelModified.Location = new System.Drawing.Point(324, 76);
            this.labelModified.Name = "labelModified";
            this.labelModified.Size = new System.Drawing.Size(65, 17);
            this.labelModified.TabIndex = 6;
            this.labelModified.Text = "Modified:";
            // 
            // dateTimePickerModified
            // 
            this.dateTimePickerModified.Enabled = false;
            this.dateTimePickerModified.Location = new System.Drawing.Point(395, 71);
            this.dateTimePickerModified.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerModified.Name = "dateTimePickerModified";
            this.dateTimePickerModified.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerModified.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(655, 511);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 30);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(533, 511);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(115, 30);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxContent.Location = new System.Drawing.Point(12, 103);
            this.richTextBoxContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(759, 402);
            this.richTextBoxContent.TabIndex = 10;
            this.richTextBoxContent.Text = "";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dateTimePickerModified);
            this.Controls.Add(this.labelModified);
            this.Controls.Add(this.dateTimePickerCreated);
            this.Controls.Add(this.labelCreated);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(799, 598);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCreated;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
        private System.Windows.Forms.Label labelModified;
        private System.Windows.Forms.DateTimePicker dateTimePickerModified;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
    }
}