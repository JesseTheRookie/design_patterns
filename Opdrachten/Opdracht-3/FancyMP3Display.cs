using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class FancyMP3Display : IObserver
    {
        private ISubject MP3Player { get; set; }
        public FancyMP3Display(ISubject player)
        {
            this.MP3Player = player;
        }
        public void Update(Nummer nummer)
        {
            Console.WriteLine("Fancy display: " + nummer.Naam + " - " + nummer.Artiest);
        }
    }
}
