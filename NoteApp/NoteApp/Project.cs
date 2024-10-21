using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{


    public static class Project
    {
        private static List<Note> notes = new List<Note>();

        /// <summary>
        /// Создать заметку и сохранить ее в notes
        /// </summary>
        public static void AddNote(string name, Categories category, string content)
        {
            Note note = new Note();

            note.ID = Guid.NewGuid();
            note.Name = name;
            note.Category = category;
            note.Content = content;
            note.DateCreate = DateTime.Now;
            note.DateModified = DateTime.Now;

            notes.Add(note);
        }

        /// <summary>
        /// Удалить заметку по уникальному GUID
        /// </summary>
        public static void DeleteNote(Guid ID)
        {
            notes.RemoveAll(x => x.ID == ID);//Найти и ликвидировать все, с заданным ID
        }

        /// <summary>
        /// Редактировать заметку по уникальному GUID
        /// </summary>
        public static void EditNote(Guid ID, string name, Categories category, string content)
        {
            Note note = notes.FirstOrDefault(x => x.ID == ID);//Найти все, с заданным ID

            note.Name = name;
            note.Category = category;
            note.Content = content;
            note.DateModified = DateTime.Now;
        }

        /// <summary>
        /// Получить заметку из notes
        /// </summary>
        public static Note GetNote(Guid ID)
        {
            Note note = notes.FirstOrDefault(x => x.ID == ID);//Найти все, с заданным ID
            Note cloneNote = (Note)note.Clone();

            return cloneNote;
        }

        /// <summary>
        /// Получить полный список notes
        /// </summary>
        public static List<Note> GetNotes()
        {
            return notes.Select(note => (Note)note.Clone()).ToList();
        }

        /// <summary>
        /// Получить имя заметки по GUID
        /// </summary>
        public static string GetNoteName(Guid ID)
        {
            Note note = notes.FirstOrDefault(x => x.ID == ID);//Найти все, с заданным ID

            return note.Name;
        }

        /// <summary>
        /// Сортировать заметки по дате
        /// </summary>
        public static List<Note> GetSortedNotes()
        {
            return notes.Select(note => (Note)note.Clone()).OrderByDescending(x => x.DateModified).ToList();
        }

        /// <summary>
        /// Сортировать заметки по дате и фильтрация категории
        /// </summary>
        public static List<Note> GetSortedNotes(Categories category)
        {
            return notes.Where(x => x.Category == category).Select(note => (Note)note.Clone()).OrderByDescending(x => x.DateModified).ToList();
        }
    }
}