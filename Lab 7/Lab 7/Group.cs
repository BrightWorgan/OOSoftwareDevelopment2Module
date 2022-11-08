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
        private List<Student> Lecture = new List<Student>();

        // constructor
        public Group(string _cRN, string _lecturerName)
        {
            cRN = _cRN;
            lecturerName = _lecturerName;
        }

        // add student method which throws an exception if ID already exists
        public void AddStudent(Student _student)
        {
            if (Lecture.Count > 0)
            {
                Student found = Lecture.FirstOrDefault(p => p.StudentID.Equals(_student.StudentID));
                if (found != null)
                {
                    throw new ArgumentException();
                }
            }
           
            Lecture.Add(_student);
        }
            

        // index 1
        public Student this[int i]
        {
            get
            {
                if ((i>=0) && (i<Lecture.Count))
                {
                    return Lecture[i];
                }
                else
                {
                    throw new ArgumentException("\n\t*** ERROR ***\n\tIndex out of range!");
                }
            }
        }
        // index 2 

    }
}
