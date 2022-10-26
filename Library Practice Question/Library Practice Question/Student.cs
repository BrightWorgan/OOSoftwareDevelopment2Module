using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Library_Practice_Question.CampusUser;
using System.Xml.Linq;


// extra logi to be fleshed out later
namespace Library_Practice_Question
{
    public class Student : CampusUser
    {
        // fields
        // ID
        private string studentID;
        public string StudentID { get; set; }

        // maximum amount of books on loan
        private int maxOnLoan;
        public int MaxOnLoan { get; set; }

        // string of books on loan
        private string outOnLoan;
        public string OutOnLoan { get; set; }

        // Constructor
        public Student(SchoolOfStudy _school, Courses _course, string _sName, string _fName, string _studentID, int _maxOnLoan) : base(_school, _course, _sName, _fName)
        {
            this.studentID = _studentID;
            this.maxOnLoan = _maxOnLoan;
        }

        //ToString()
        public override string ToString()
        {
            return base.ToString() + "\n\tStudent ID: " + studentID + "Can borrow " + maxOnLoan + " books in total";
        }
    }
}
