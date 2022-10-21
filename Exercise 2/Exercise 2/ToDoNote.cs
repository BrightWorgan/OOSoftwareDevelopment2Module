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
    public class ToDoNote : SerialisedXML
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
            XmlTextWriter x = new XmlTextWriter(filename, encoding: Encoding.UTF8);
            x.WriteStartElement("ToDoNote");
            x.WriteElementString("Note Title", noteTitle);
            x.WriteElementString("Due Date", dueDate.ToLongDateString());
            x.WriteElementString("Note Priority", notePriority.ToString());
            x.WriteEndElement();
            x.Close();

        }

        // public void XMLTextWriter
    }
}
