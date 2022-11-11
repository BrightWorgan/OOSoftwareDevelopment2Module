using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Library
{
    // enum
    public enum Genres
    {
        Action,
        Adventure,
        Drama,
        Crime,
        Horror,
        Thriller,
        Family,
        Fantasy,
        Sci_Fi,
        Comedy,
        Romance,
        Animation,
        Mystery,
        Music,
        Musical,
        Biography,
        History,
        War,
        Western,
        Martial_Arts,
        Sport,
        _____, // blavk for when a film does not have a third genre

    }
    public class Film
    {
        // title
        public string Title { get; set; }

        // realeseYr
        public DateOnly ReleaseYr { get; set; }

        // Primary Genre
        public Genres Primary { get; set; }

        // secondary Genre
        public Genres Secondary { get; set; }

        // Tertiary Genre
        public Genres Tertiary { get; set; }

        // rating
        public int Rating { get; set; }

        // constructor
        public Film(string Title, DateOnly ReleaseYr, Genres Primary, Genres Secondary, Genres Tertiary, int Rating)
        {
            this.Title = Title; 
            this.ReleaseYr = ReleaseYr;
            this.Primary = Primary;
            this.Secondary = Secondary;
            this.Tertiary = Tertiary;
            this.Rating = Rating;
        }

       
    }
}
