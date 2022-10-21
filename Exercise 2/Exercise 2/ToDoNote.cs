using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace Exercise_2
{
    class ToDoNote
    {
        // list of notes
        public List<string> list = new List<string>();
        public string[] ToDoList = {};

        // enum with the different note priority options
        public enum Priority
        {
            low,
            normal,
            high
        }
        // fields
        public string noteTitle { get; set; }
        public DateTime dueDate { get; set; }

        protected Priority notePriority;
        public Priority NotePriority { get { return notePriority; } }

        // constructor
        public ToDoNote(string _noteTitle, DateTime _dueDate, Priority _noteImportance )
        {
            noteTitle = _noteTitle;
            dueDate = _dueDate;
            notePriority = _noteImportance;
        }

        // overwrite ToString()
        public override string ToString()
        {
            return "\tNote Priority: " + notePriority + "\n\tNote Title: " + noteTitle + "\n\tDate Due: " + dueDate;
        }

        // serialization 
        public void WriteXMLToFile(string filename)
        {
            XmlTextWriter x = new XmlTextWriter(filename);
            //x.
            x.WriteStartElement("ToDoNote");
            x.WriteAttributeString("xmlns", "x", null, "urn:1");
            x.WriteStartElement("item", "Note Title");
            x.WriteEndElement();
            x.WriteStartElement("item", "Date Due");
            x.WriteEndElement();
            x.WriteStartElement("item", "Note Priority");
            x.WriteEndElement();
            x.WriteEndElement();

            /*info.AddValue("Note Priority: ", noteTitle, typeof(string));

            info.AddValue("Date Due: ", dueDate, typeof(DateTime));

            info.AddValue("Note Priority: ", notePriority, typeof(Priority));*/
        }

        // public void XMLTextWriter
    }
}
