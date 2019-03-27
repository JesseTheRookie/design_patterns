using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Single : IVinylSingle
    {
        private string Artist { get; set; }
        private int Ranking { get; set; }
        private string Title { get; set; }

        public Single(int ranking, string title, string artist)
        {
            this.Artist = artist;
            this.Ranking = ranking;
            this.Title = title;
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
            return $"Playing single '{Title}', {Artist} ({Ranking})";
        }
    }
}
