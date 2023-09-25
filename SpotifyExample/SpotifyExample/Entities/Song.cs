using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyExample.Entities
{
    internal class Song
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }

        public string Genre { get; set; }

        public int Released { get; set; }

        public Song()
        {
            Id = Guid.NewGuid();
        }
        public Song(string title, string artist, string genre, int released) :this() 
        {
            Title = title;
            Artist = artist;
            Genre = genre;
            Released = released;
        }

    }
}
