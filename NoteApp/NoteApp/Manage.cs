using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    class Manage
    {
        private List<Note> notes;

        /// <summary>
        /// Создать заметку и сохранить ее в notes
        /// </summary>
        public void AddNote(string name, string category, string content)
        {
            Note note = new Note();

            note.ID = Guid.NewGuid();
            note.Name = name;
            note.Category = category;
            note.DateCreate = DateTime.Now;
            note.DateModified = DateTime.Now;

            notes.Add(note);
        }

        /// <summary>
        /// Удалить заметку по уникальному GUID
        /// </summary>
        public void DeleteNote(Guid ID)
        {
            notes.RemoveAll(x => x.ID == ID);//Найти и ликвидировать все, с заданным ID
        }

        /// <summary>
        /// Редактировать заметку по уникальному GUID
        /// </summary>
        public void EditNote(Guid ID, string name, string category, string content)
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
        public Note GetNote(Guid ID)
        {
            Note note = notes.FirstOrDefault(x => x.ID == ID);//Найти все, с заданным ID
            Note cloneNote = new Note();

            //Для того, чтобы другой объект не получил доступ непосредственно к notes (для сохранения инкапсуляции)
            cloneNote.ID = note.ID;
            cloneNote.Name = note.Name;
            cloneNote.Category = note.Category;
            cloneNote.DateCreate = note.DateCreate;
            cloneNote.DateModified = note.DateModified;

            return cloneNote;
        }
    }
}
