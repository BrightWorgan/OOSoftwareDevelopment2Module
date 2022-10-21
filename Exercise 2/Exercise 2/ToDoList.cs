using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    public class ToDoList
    {
        // fields
        public string listOwner { get; set; }

        private List<ToDoNote> ListOfNotes;

        public ToDoNote this[int i]
        {
            get { return ListOfNotes[i];  }
        }

        // constructor
        public ToDoList(string _listOwner)
        {
            listOwner = _listOwner;

            ListOfNotes = new List<ToDoNote>();
        }

        public void Add(ToDoNote note)
        {
            ListOfNotes.Add(note);
        }


    }
}
