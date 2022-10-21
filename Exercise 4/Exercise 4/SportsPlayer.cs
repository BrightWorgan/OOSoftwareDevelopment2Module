using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public abstract class SportsPlayer
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
        // player name
        public string Name { get; set; }
        // player age
        public int Age { get; set; }
        // gender
        public Gender PlayerGender { get; set; }

        // constructor
        public SportsPlayer(string _name, int _age, Gender _gender)
        {
            Name = _name;
            Age = _age;
            PlayerGender = _gender;
        }

        // override ToString()
        public override string ToString()
        {
            return "\tPlayer Name: " + Name + "\n\tPlayer Age: " + Age + "\n\tPlayer Gender: " + Gender;
        }
    }
}
    