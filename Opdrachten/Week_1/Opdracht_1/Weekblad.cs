using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Weekblad : BoekHandelItem
    {
        private string UitgifteDag { get; set; }
        public Weekblad(string uitgifteDag, string titel, float prijs, int aantal)
            : base(titel, prijs, aantal)
        {
            this.UitgifteDag = uitgifteDag;
        }
        public override string ToString()
        {
            return "" + UitgifteDag + " " + Titel + " " + Prijs + " " + Aantal;
        }
    }
}
