using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_8
{
    internal class Song
    {
        public Song(string name, string author) 
        {
            this.name = name;
            this.author = author;
        }
        string name, author;
        Song prev;
        public Song Previous
        {
            get { return prev; }
            set { prev = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Title()
        {
            string s = name + " - " + author;
            return s;
        }

        public bool Equals_songs(object d)
        {
            Song previous_song = d as Song;
            if (previous_song != null && Title() == previous_song.Title())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
