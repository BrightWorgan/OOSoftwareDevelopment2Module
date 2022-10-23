using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class FavouritesCollection : IEnumerable
    {
        private List<Favourite> bookmarks;
        public List<Favourite> Bookmarks {
            get
            {
                return bookmarks;
            } 
        }
        
        // Indexer 
        public Favourite this [string name]{
            get
            { 
                foreach (Favourite f in bookmarks)
                {
                    if (f.UrlName == name)
                    {
                        return f;
                    }
                }
               throw new Exception("\t That URL Name is not in your Favourites!");
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

        public IEnumerator GetEnumerator()
        {
            return bookmarks.GetEnumerator();
        }


    }
}