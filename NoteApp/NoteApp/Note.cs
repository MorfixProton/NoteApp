using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Note
    {
        public Guid ID { get; set; }//GUIG - уникальный идетификатор, который генерируется на лету
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateModified { get; set; }
        public string Content { get; set; }
    }
}