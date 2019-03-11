using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class Nummer
    {
        public string Naam { get; set; }
        public string Artiest { get; set; }
        public Nummer(string naam, string artiest)
        {
            this.Naam = naam;
            this.Artiest = artiest;
        }
    }
}
