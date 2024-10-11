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

        public EditForm()
        {
            InitializeComponent();
            comboBoxCategory.Items.Add("Работа");
            comboBoxCategory.Items.Add("Дом");
            comboBoxCategory.Items.Add("Здоровье и Спорт");
            comboBoxCategory.Items.Add("Люди");
            comboBoxCategory.Items.Add("Документы");
            comboBoxCategory.Items.Add("Финансы");
            comboBoxCategory.Items.Add("Разное");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                MessageBox.Show("Нет названия заметки!");
            }
            else
            {
                if (comboBoxCategory.Text == "")
                {
                    MessageBox.Show("Не выбрана категория!");
                }
                else
                {
                    var notes = Project.GetNotes();

                    if (notes.FirstOrDefault(x => x.ID == noteID) == null)
                    {
                        Project.AddNote(textBoxTitle.Text, comboBoxCategory.Text, richTextBoxContent.Text);
                    }
                    else
                    {
                        Project.EditNote(noteID, textBoxTitle.Text, comboBoxCategory.Text, richTextBoxContent.Text);
                    }


                    Close();
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
            Note note = Project.GetNote(ID);
            textBoxTitle.Text = note.Name;
            comboBoxCategory.Text = note.Category;
            dateTimePickerCreated.Value = note.DateCreate;
            note.DateModified = DateTime.Now;
            dateTimePickerModified.Value = note.DateModified;
            richTextBoxContent.Text = note.Content;
        }
    }
}
