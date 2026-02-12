using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jabines_Songoop
{
    public class Songs
    {
        public string Title { get;protected set; }
        public string Artist { get;protected set; }
        public string Album { get;protected set; }
        public string Genre{ get;protected set; }
        public Songs(string title, string artist, string album, string genre)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Genre = genre;
        }
        public virtual string Display()
        {
            return $"Title: {Title} by {Artist} \nfrom the album {Album}, \nGenre: {Genre}";
        }


    }

    public class Extrasong : Songs
    {
        public string Duration { get; protected set; }

        public Extrasong(string title, string artist, string album, string genre, string duration)
            : base(title, artist, album, genre)
        {
            Duration = duration;
        }

        public override string Display() 
        {
            return $"Tilte{Title} by {Artist} \nfrom the album {Album}, \nGenre: {Genre}, \nDuration: {Duration}";
        }
    }
}
