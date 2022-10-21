// See https://aka.ms/new-console-template for more information
using Exercise_4;
using static Exercise_4.SoccerPlayer;
using static Exercise_4.SportsPlayer;

namespace Exercise_4
{
    public class Program
    {
        static void Main()
        {
            SoccerPlayer s1 = new SoccerPlayer("William", 25, Gender.Male, SoccerPosition.Striker);
            System.Console.WriteLine(s1.ToString());
            SoccerTeam afc = null;

            try
            {
                afc = new SoccerTeam("Atlantis FC", Gender.Male, 200);
                afc.AddPlayer(s1);
                afc.AddPlayer(new SoccerPlayer("John", 32, Gender.Male, SoccerPosition.Striker));
                afc.AddPlayer(new SoccerPlayer("Moe", 30, Gender.Male, SoccerPosition.Goalie));
                afc.AddPlayer(new SoccerPlayer("Sam", 29, Gender.Male, SoccerPosition.MidFielder));
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

            if (afc != null)
            {
                foreach (SoccerPlayer sp in afc)
                {
                    System.Console.WriteLine(sp.ToString());
                }
            }
        }



    }
}
