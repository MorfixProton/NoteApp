using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTest
{
    [TestFixture]
    class UTestProject
    {
        [Test(Description = "Тест добавления заметки и проверки, что все внесено корректно.")]
        public void TestAddNote()
        {
            Project project = new Project();

            project.AddNote("Name", Categories.Work, "Text");

            List<Note> notes = project.GetNotes();

            Assert.AreEqual(notes.Count, 1, "Количество заметок не соответствует количеству добавленных заметок (должно быть = 1).");

            Note note = notes[0];

            Assert.AreEqual(note.Name, "Name", "Имя заметки не соответствует исходному.");
            Assert.AreEqual(note.Category, Categories.Work, "Категория заметки не соответствует исходной.");
            Assert.AreEqual(note.Content, "Text", "Контент заметки не соответствует исходному.");
        }

        [Test(Description = "Тест удаления заметки.")]
        public void TestDeleteNote()
        {
            Project project = new Project();

            project.AddNote("Name", Categories.Work, "Text");

            List<Note> notes = project.GetNotes();

            Assert.AreEqual(notes.Count, 1, "Количество заметок не соответствует количеству добавленных заметок (должно быть = 1).");

            Note note = notes[0];

            project.DeleteNote(note.ID);

            Assert.AreEqual(project.GetNotes().Count, 0, "Количество заметок не соответствует количеству заметок после удаления (должно быть = 0).");
        }

        [Test(Description = "Тест получения заметки, редактирования и получения имени заметки.")]
        public void TestGetEditGetNameNote()
        {
            Project project = new Project();

            project.AddNote("Name", Categories.Work, "Text");

            List<Note> notes = project.GetNotes();

            Assert.AreEqual(notes.Count, 1, "Количество заметок не соответствует количеству добавленных заметок (должно быть = 1).");

            Note note = notes[0];

            project.EditNote(note.ID, "Name1-1", Categories.Work, "Text1-1");

            Note getNote = project.GetNote(note.ID);

            Assert.AreEqual(getNote.Name, "Name1-1", "Имя заметки не соответствует исходному.");
            Assert.AreEqual(getNote.Category, Categories.Work, "Категория заметки не соответствует исходной.");
            Assert.AreEqual(getNote.Content, "Text1-1", "Контент заметки не соответствует исходному.");

            string noteName = project.GetNoteName(note.ID);

            Assert.AreEqual(noteName, getNote.Name, "Имя заметки не соответствует.");
        }

        [Test(Description = "Тест сортировки заметок по дате.")]
        public void TestSortByDate()
        {
            Project project = new Project();

            project.AddNote("Name1", Categories.Work, "Text1");
            Thread.Sleep(10);
            project.AddNote("Name2", Categories.Work, "Text2");
            Thread.Sleep(10);
            project.AddNote("Name3", Categories.Work, "Text3");

            List<Note> notes = project.GetNotes();
            Note note = notes[0];

            Thread.Sleep(10);
            project.EditNote(note.ID, "Name1-1", Categories.Work, "Text1-1");

            List<Note> sortedNotes = project.GetSortedNotes();

            Assert.Greater(sortedNotes[0].DateModified, sortedNotes[1].DateModified, "Заметки отсортированы не верно.");
        }

        [Test(Description = "Тест сортировки заметок по дате и категории.")]
        public void TestSortByDateAndCategory()
        {
            Project project = new Project();

            project.AddNote("Name1", Categories.Work, "Text1");
            Thread.Sleep(10);
            project.AddNote("Name2", Categories.Finance, "Text2");
            Thread.Sleep(10);
            project.AddNote("Name3", Categories.Work, "Text3");

            List<Note> notes = project.GetNotes();
            Note note = notes[0];

            Thread.Sleep(10);
            project.EditNote(note.ID, "Name1-1", Categories.Work, "Text1-1");

            List<Note> sortedNotes = project.GetSortedNotes(Categories.Work);


            Assert.Greater(sortedNotes[0].DateModified, sortedNotes[1].DateModified, "Заметки отсортированы не верно.");

            Assert.AreEqual(sortedNotes.Count, 2, "Количество заметок в отсортированной категории не верно.");
        }
    }
}