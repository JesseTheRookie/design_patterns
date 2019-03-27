using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Album : IVinylAlbum
    {
        private string Band { get; set; }
        private string Title { get; set; }
        private int Year { get; set; }

        public Album(string band, string title, int year)
        {
            this.Band = band;
            this.Title = title;
            this.Year = year;
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Playing album '{Title}', {Band} ({Year})";
        }
    }
}
