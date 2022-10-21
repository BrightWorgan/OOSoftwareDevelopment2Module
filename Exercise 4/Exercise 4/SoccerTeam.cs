using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise_4.SportsPlayer;

namespace Exercise_4
{
    public class SoccerTeam : IEnumerable
    {
        public string TeamName { get; set; }
        public Gender TeamGender { get; set; }

        private int ageLimit;
        public int AgeLimit
        {
            get { return this.ageLimit; }
            set
            {
                //checks if the Player's age is 5 or greater
                if (value < 5)
                {
                    throw new ArgumentOutOfRangeException("\t*** ERROR ***\n\tMinimum Age is 5 yrs"); 
                }
                ageLimit = value;
            }
        }
        
        // collection of players
        private List<SoccerPlayer> players;
        
        // constructor
        public SoccerTeam(string _teanName, Gender _teamGender, int _ageLimit)
        {
            players = new List<SoccerPlayer>();
            this.TeamName = _teanName;
            this.TeamGender = _teamGender;
            this.AgeLimit = _ageLimit;
        }
        
        
        // IEnumerator 
        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }

        //
        public SoccerPlayer this[string _name]
        {
            get
            {
                for (int i = 0; i < players.Count(); i++)
                {
                    if (players[i].Name.Equals(_name))
                    {
                        return (players[i]);
                    }
                }
                throw new IndexOutOfRangeException("Invalid name index value passed!");
            }
        }

        //
        public void AddPlayer(SoccerPlayer sp)
        {
            if (sp.Age < AgeLimit)
            {
                throw new Exception("Player too young!");
            }
            if (sp.PlayerGender != TeamGender)
            {
                throw new Exception("Player is wrong gender!");
            }
            if (PlayerAlreadyAdded(sp))
            {
                throw new Exception("Player already added!");
            }
            players.Add(sp);
        }

        //
        private bool PlayerAlreadyAdded(SoccerPlayer searchSp)
        {
            foreach (SoccerPlayer sp in players)
            {
                if (sp.Name.Equals(searchSp.Name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
