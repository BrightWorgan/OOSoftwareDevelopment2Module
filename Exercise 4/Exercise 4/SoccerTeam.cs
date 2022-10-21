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
        public SoccerTeam(string _teanName, Gender _teamGender, _ageLimit)
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
        public SoccerPlayer this[String _name]
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
            if (players.Count() == 0)
            {
                players.Add(sp);
            }
            else
            {
                if (PlayerAlreadyAdded(sp))
                {
                    throw new ArgumentException("\tPlayer already added to squad!");
                }
                else
                {
                    if (sp.Age <= AgeLimit)
                    {
                        if (sp.Gender == TeamGender)
                        {
                            players.Add(sp);
                        }
                    }
                }
            }

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
