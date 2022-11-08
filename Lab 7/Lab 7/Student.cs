using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Student
    {
        public enum Gender
        {
            Female = 0,
            Male = 1,
            Trans = 2,
            NonBinary = 3,
            GenderNeutral = 4,
            Other = 5
        }
       
        // unique ID
        protected string studentID;
        public string StudentID { get { return studentID; } }

        // name
        protected string studentName;
        public string StudentName { get { return studentName; } }

        // gender
        protected Gender studentGender;
        public Gender StudentGender { get { return studentGender; } }


        // constructor
        public Student(string _studentID, string _studentName, Gender _studentgender)
        {
            studentID = _studentID;
            studentName = _studentName;
            studentGender = _studentgender;
        }

        // Tostring()
        public override string ToString()
        {
            return String.Format("\n\tStudent Name: {0}\n\tStudent ID: {1}\n\tStudent Gender: {2}", StudentID, StudentName, StudentGender);
        }
    }
}
