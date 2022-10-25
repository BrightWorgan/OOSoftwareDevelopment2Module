using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// extra logi to be fleshed out later
namespace Library_Practice_Question
{
    public class Student : CampusUser
    {
        // fields
        // ID
        private string studentID;
        public string StudnetID { get; set; }

        // name
        private string name;
        public string Name { get { return name; } set { name = value; } }

        // maximum amount of books on loan
        // course
        // school

        // Constructor
        public Student(string _studentID, string _name)
        {
            this.studentID = _studentID;
            this.name = _name;

        }

    }
}
