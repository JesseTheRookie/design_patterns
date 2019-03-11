using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class SimpleMP3Display : IObserver
    {
        private ISubject MP3Player { get; set; }
        public SimpleMP3Display(ISubject mP3Player)
        {
            this.MP3Player = mP3Player;
        }
        public void Update(Nummer nummer)
        {
            Console.WriteLine("Simple display: " + nummer.Artiest + " - " + nummer.Naam);
        }
    }
}
