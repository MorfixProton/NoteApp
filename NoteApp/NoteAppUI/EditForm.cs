using NoteApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class EditForm : Form
    {
        private Guid noteID;

        private Project project;

        public EditForm(Project project)
        {
            InitializeComponent();

            foreach(Categories categories in Enum.GetValues(typeof(Categories)))
            {
                comboBoxCategory.Items.Add(new ComboBoxItem<Categories>(CategoryName.GetName(categories), categories));
            }

            this.project = project;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                MessageBox.Show("There is no title of the note!");
            }
            else
            {
                if (comboBoxCategory.Text == "")
                {
                    MessageBox.Show("No category selected!");
                }
                else
                {
                    if (textBoxTitle.Text.Length > 50)
                    {
                        MessageBox.Show("The name of the note cannot exceed 50 characters!");
                    }
                    else
                    {
                        var notes = project.GetNotes();

                        if (notes.FirstOrDefault(x => x.ID == noteID) == null)
                        {
                            project.AddNote(textBoxTitle.Text, ((ComboBoxItem<Categories>)comboBoxCategory.SelectedItem).Value, richTextBoxContent.Text);
                        }
                        else
                        {
                            project.EditNote(noteID, textBoxTitle.Text, ((ComboBoxItem<Categories>)comboBoxCategory.SelectedItem).Value, richTextBoxContent.Text);
                        }

                        Close();
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetValues(Guid ID)
        {
            noteID = ID;
            Note note = project.GetNote(ID);
            textBoxTitle.Text = note.Name;
            comboBoxCategory.Text = CategoryName.GetName(note.Category);
            dateTimePickerCreated.Value = note.DateCreate;
            note.DateModified = DateTime.Now;
            dateTimePickerModified.Value = note.DateModified;
            richTextBoxContent.Text = note.Content;
        }
    }
}
