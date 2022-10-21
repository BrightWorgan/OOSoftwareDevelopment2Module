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
        public SoccerPlayer(string _name, int _age, Gender _gender, SoccerPosition _position) : base("", 0, Gender.Male)
        {
            Position = SoccerPosition.Defender;
        }
        //
        public override string ToSting()
        {
            return base.ToString() + "\tPlayer's Position : " + Position;
        }
    }
}
