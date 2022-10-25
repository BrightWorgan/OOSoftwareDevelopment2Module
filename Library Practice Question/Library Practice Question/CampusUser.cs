using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Library_Practice_Question.Book;

namespace Library_Practice_Question
{
    public class CampusUser
    {
        // enum of schools
        public enum SchoolOfStudy
        {
            Science,
            Medicine,
            Arts,
            Computer,
            Engineering,
            Physical_Education,
            Business_and_Accounting,
            Hospitality,
            Tourism,
            Soical_Science,
            Architecture,
            Music,
            Drama,
            Law
        }
        // enum of courses
        public enum Courses
        {
            Applied_Archaeology,
            Biology,
            Early_Childhood_Edcation,
            Higher_Dioplam_in_Computing,
            Construction_Managemnt,
            Quantity_Surveying,
            Nursing,
            Geographic_Information_Systems,
            Sustainable_Development,
            Sustainable_Transport_and_Mobility,
            Creative_Digital_Media,
            Journalism,
            Public_Relations,
            Communication,
            Social_Care,
            Law,
            Law_with_a_Language,
            International_Business,
            Accounting,
            Marketing,
            Computer_Science,
            Game_Developement,
            Web_Development,
            Culinary_Arts,
            Culinary_Science,
            Baking_and_Pastry_Arts_Management,
            Bar_and_Restuarant_Management
        }
        
        // name (forename and surname)
        private string fName;
        public string FName { get { return fName; } set { fName = value; } }

        private string sName;
        public string SName { get { return sName; } set { sName = value; } }

        // School/Department
        private SchoolOfStudy school;
        public SchoolOfStudy School
        {
            get { return school; }
            set { school = (SchoolOfStudy)value; }
        }

        // Course
        private Courses course;
        public Courses Course
        {
            get { return course; }
            set { course = (Courses)value; }
        }


        // constructor
        public CampusUser(SchoolOfStudy _school, Courses _course, string _sName, string _fName )
        {
            SchoolOfStudy school = _school;
            this.course = _course;
            this.sName = _sName;
            this.fName = _fName;
        }

        // override ToString()
        public override string ToString()
        {
            return "\tName: " + sName + " " + fName + "\t Department: " + school + "\tCourse: " + course;
        }
    }
}
