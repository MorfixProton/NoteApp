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
    public partial class MainForm : Form
    {
        private Guid GUID;

        private Project project;

        public MainForm()
        {
            InitializeComponent();

            comboBoxCategory.Items.Add("All");

            foreach (Categories categories in Enum.GetValues(typeof(Categories)))
            {
                comboBoxCategory.Items.Add(new ComboBoxItem<Categories>(CategoryName.GetName(categories), categories));
            }

            project = ProjectManager.LoadFromFile();
            RefreshList();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(project);
            editForm.ShowDialog();
            ProjectManager.SaveToFile(project);
            RefreshList();
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(project);
            editForm.ShowDialog();
            ProjectManager.SaveToFile(project);
            RefreshList();
        }

        private void RefreshList()
        {
            editNoteToolStripMenuItem.Enabled = false;
            removeNoteToolStripMenuItem.Enabled = false;
            buttonEditNote.Enabled = false;
            buttonDeleteNote.Enabled = false;

            labelName.Text = "";
            labelCategory.Text = "";
            richTextBox1.Text = "";

            listViewNotes.Items.Clear();

            List<Note> notes;

            if (comboBoxCategory.SelectedItem is ComboBoxItem<Categories>)
            {
                notes = project.GetSortedNotes(((ComboBoxItem<Categories>)comboBoxCategory.SelectedItem).Value);
            }
            else
            {
                notes = project.GetSortedNotes();
            }

            foreach (var Note in notes)
            {
                listViewNotes.Items.Add(new ListViewItem(Note.Name) { Tag = Note.ID });
            }
        }

        private void listViewNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNotes.SelectedItems.Count == 0)
            {
                buttonEditNote.Enabled = false;
                buttonDeleteNote.Enabled = false;
                editNoteToolStripMenuItem.Enabled = false;
                removeNoteToolStripMenuItem.Enabled = false;
                return;
            }
            else
            {
                GUID = (Guid) listViewNotes.SelectedItems[0].Tag;
                Note note = project.GetNote(GUID);

                labelName.Text = note.Name;
                labelCategory.Text = CategoryName.GetName(note.Category);
                richTextBox1.Text = note.Content;
                dateTimePickerCreated.Value = note.DateCreate;
                dateTimePickerModified.Value = note.DateModified;

                buttonEditNote.Enabled = true;
                buttonDeleteNote.Enabled = true;
                editNoteToolStripMenuItem.Enabled = true;
                removeNoteToolStripMenuItem.Enabled = true;
            }
        }

        private void buttonDeleteNote_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to remove this note: " + project.GetNoteName(GUID), "Delete a note", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                project.DeleteNote(GUID);
                ProjectManager.SaveToFile(project);
                RefreshList();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to remove this note: " + project.GetNoteName(GUID), "Delete a note", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                project.DeleteNote(GUID);
                ProjectManager.SaveToFile(project);
                RefreshList();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(project);
            editForm.SetValues(GUID);
            editForm.ShowDialog();
            ProjectManager.SaveToFile(project);
            RefreshList();
            var item = listViewNotes.Items.OfType<ListViewItem>().FirstOrDefault(x => (Guid)x.Tag == GUID);
            item.Selected = true;
            listViewNotes.Select();
        }

        private void buttonEditNote_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(project);
            editForm.SetValues(GUID);
            editForm.ShowDialog();
            ProjectManager.SaveToFile(project);
            RefreshList();
            var item = listViewNotes.Items.OfType<ListViewItem>().FirstOrDefault(x => (Guid)x.Tag == GUID);
            item.Selected = true;
            listViewNotes.Select();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (buttonDeleteNote.Enabled)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you really want to remove this note: " + project.GetNoteName(GUID), "Delete a note", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        project.DeleteNote(GUID);
                        ProjectManager.SaveToFile(project);
                        RefreshList();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
            }  
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(project);
        }
    }
}