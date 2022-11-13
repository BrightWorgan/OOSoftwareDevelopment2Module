using Film_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Library
{
    public class Cinema
    {
        // Checklist List
        List<Film> checklList = new List<Film>();
     
        // queue for what to watch next!
        Queue<Film> watchNext = new Queue<Film>();


        // uses a foreach to add films to watchNext queue (if film rating is 0)
        public void AddItem() 
        {
            foreach (Film film in checklList)
            {
                if (film.Rating == 0)
                {
                    watchNext.Enqueue(film);

                }
            }
        }
        // adds a film to the queue one at a time
        // watchNext.Enqueue(f1);


        // remove a film
        public void RemoveFilm(Film userFilm)
        {
            foreach (Film film in watchNext)
            {
                if (film.Title == userFilm.Title)
                {
                    watchNext.TryDequeue(out userFilm);

                }
            }
        }



        // print out a film at random from queue

        // fiveStar List
        List<Film> fiveStar = new List<Film>();
        public void AddFiveStarItem()
        {
            foreach (Film film in checklList)
            {
                if (film.Rating == 5)
                {
                    fiveStar.Add(film);
                }
            }
        }


        // prints out only 5* rated films watched so far
        public void PrintHotFimls()
        {
            for (int i = 0; i < fiveStar.Count; i++)
            {
                Console.WriteLine(fiveStar[i]);
            }
        }
    
    }
}
