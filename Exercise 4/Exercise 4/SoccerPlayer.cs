using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public class SoccerPlayer : SportsPlayer
    {
        public enum SoccerPosition
        {
            Goalie,
            Defender,
            MidFielder,
            Striker
        }
        public SoccerPosition Position { get ; set; } 

        // constructor
        public SoccerPlayer(string _name = "", int _age = 0, Gender _gender = Gender.Male, SoccerPosition _position = SoccerPosition.Defender) : base(_name, _age, _gender)
        {
            Position = _position;
        }
        //
        public override string ToString()
        {
            return base.ToString() + "\tPlayer's Position : " + Position;
        }
    }
}
