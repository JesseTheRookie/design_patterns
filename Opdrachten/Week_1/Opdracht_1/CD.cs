using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class CD : BoekHandelItem
    {
        private string Artiest { get; set; }
        public CD(string artiest, string titel, float prijs, int aantal)
            : base(titel, prijs, aantal)
        {
            this.Artiest = artiest;
        }
        public override string ToString()
        {
            return "" + Artiest + " " + Titel + " " + Prijs + " " + Aantal;
        }
    }
}
