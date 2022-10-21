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
            SoccerPlayer player = new SoccerPlayer("Jessica", 22, Gender.Female, SoccerPosition.Goalie);
            SoccerTeam team = new SoccerTeam("The Flaming Joe's", Gender.Female, 18);
            team.AddPlayer(player);

            foreach(SoccerPlayer x in team)
            {
                Console.WriteLine(x.Name);
            }
        }
    }
}
