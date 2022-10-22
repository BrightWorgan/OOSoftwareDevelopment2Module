using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class FavouritesCollection
    {
        private List<Favourite> bookmarks;
        public List<Favourite> Bookmarks {
            get
            {
                return bookmarks;
            } 
        }

        // constructor
        public FavouritesCollection() 
        {
            bookmarks = new List<Favourite>();
        }

        // Add Method
        public void Add(Favourite item)
        {
            // uses a loop to check every pre-existing url name
            foreach (Favourite i in bookmarks)
            {
                if (i.UrlName == item.UrlName)
                {
                    throw new ArgumentException("\tERROR!\n\tThat URL Name already exists");
                }
                
            }     
            Bookmarks.Add(item);
        }

        // Remove Method
        public void Remove(string UrlName)
        {
            // uses a loop to check every pre-existing url name
            foreach (Favourite i in bookmarks)
            {
                if (i.UrlName == UrlName)
                {
                    Bookmarks.Remove(i);
                    return;
                }
            }
            throw new ArgumentException("\tERROR!\n\tThat URL Name does not exist");
        }


    }
}
