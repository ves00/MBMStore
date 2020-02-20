using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        // fields
        private List<Track> tracks = new List<Track>();
        //auto implemnted properties
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }


        // properties
        public List<Track> Tracks
        {
            get { return tracks; }
        }


        // constructors
        public MusicCD()
        {

        }

        public MusicCD(int productId, string title, decimal price, string imageUrl, string artist, short released) : base(productId, title, price, imageUrl)
        {
            this.Artist = artist;
            this.Label = Label;
            this.Released = released;
        }


        // methods
        public void AddTrack(string artist, string composer, TimeSpan length)
        {
            tracks.Add(new Track(artist, composer, length));
        }

        public TimeSpan GetPlayingTime ()
        {
            TimeSpan total = new TimeSpan();
            foreach (Track track in tracks)
            {
                total += track.Length;
            }
            return total;
        }
    }
}
