using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Library
{
    public class ChecklList
    {
        public List<Film> posterList
        {
            get
            {
                return posterList;
            }
        }
        //posterList = new List<Film>();

        //List<Film> AuthorList = new List<Film>();

        Film d1 = new() { Title = "Casablanca", ReleaseYr = new DateOnly(2022, 1, 1), Primary = Genres.Sci_Fi, Secondary = Genres.Fantasy, Tertiary = Genres.Adventure, Rating = 4 };
        Film d2 = new() { Title = "Enter the Dragon", ReleaseYr = new DateOnly(2022, 1, 1), Primary = Genres.Sci_Fi, Secondary = Genres.Fantasy, Tertiary = Genres.Adventure, Rating = 4 };
        Film d3 = nnew() { Title = "Endless", ReleaseYr = new DateOnly(2022, 1, 1), Primary = Genres.Sci_Fi, Secondary = Genres.Fantasy, Tertiary = Genres.Adventure, Rating = 4 };

    List<Film> DogsList = new List<Film>();

        DogsList.Add(d1);
        DogsList.Add(d2);
        DogsList.Add(d3);
  
    }
}
    // public Film(string Title, DateOnly ReleaseYr, Genres Primary, Genres Secondary, Genres Tertiary, int Rating)    }