using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    class ComboBoxItem<T>
    {
        public string Text { get; }
        public T Value { get; }

        public override string ToString()
        {
            return Text;
        }

        public ComboBoxItem( string text, T value)
        {
            Value = value;
            Text = text;
        }
    }
}
