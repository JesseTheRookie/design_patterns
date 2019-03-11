using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Boek : BoekHandelItem
    {
        private string Auteur { get; set; }
        public Boek(string auteur, string titel, float prijs, int aantal) 
            : base(titel, prijs, aantal)
        {
            this.Auteur = auteur;
        }
        public override string ToString()
        {
            return "" + Auteur + " " + Titel + " " + Prijs + " " + Aantal;
        }
    }
}
