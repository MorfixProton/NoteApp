using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Note:ICloneable
    {
        public Guid ID { get; set; }//GUIG - уникальный идетификатор, который генерируется на лету
        public string Name { get; set; }
        public Categories Category { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateModified { get; set; }
        public string Content { get; set; }

        public object Clone()
        {
            return new Note
            {
                //Для того, чтобы другой объект не получил доступ непосредственно к notes (для сохранения инкапсуляции)
                ID = this.ID,
                Name = this.Name,
                Category = this.Category,
                Content = this.Content,
                DateCreate = this.DateCreate,
                DateModified = this.DateModified
            };
        }
    }
}