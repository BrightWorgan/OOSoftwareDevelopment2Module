using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab_7.Student;

namespace Lab_7
{
    class Group
    {
        // is a class of students
        // class reference number) which is unique
        // unique ID
        protected string cRN;
       
        public string CRN { get { return cRN; } }
        // lecturer name
        protected string lecturerName;
        public string LecturertName { get { return lecturerName; } }

        // collection of students attending the class
        // i.e. an ArrayList of Students

        // constructor
        public Group(string _cRN, string _lecturerName)
        {
            cRN = _cRN;
            lecturerName = _lecturerName;
        }

        // add student method which throws an exception if ID already exists

        // index 1
        // index 2 

    }
}
