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
        private Guid ID;

        public MainForm()
        {
            InitializeComponent();
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
            EditForm editForm = new EditForm();
            editForm.ShowDialog();
            RefreshList();
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.ShowDialog();
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

            var notes = Project.GetNotes();
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
                ID = (Guid) listViewNotes.SelectedItems[0].Tag;
                Note note = Project.GetNote(ID);

                labelName.Text = note.Name;
                labelCategory.Text = note.Category;
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
            Project.DeleteNote(ID);
            MessageBox.Show("Заметка удалена!");
            RefreshList();
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project.DeleteNote(ID);
            MessageBox.Show("Заметка удалена!");
            RefreshList();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.SetValues(ID);
            editForm.ShowDialog();
            RefreshList();
        }

        private void buttonEditNote_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.SetValues(ID);
            editForm.ShowDialog();
            RefreshList();
        }
    }
}