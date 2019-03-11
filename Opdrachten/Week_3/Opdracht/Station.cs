using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht
{
    public class Station
    {
        public string Naam { get; set; }
        public string AankomstSpoor { get; set; }
        public DateTime AankomstTijd { get; set; }
        public DateTime VertrekTijd { get; set; }

        public Station(string naam, string aankomstSpoor, DateTime aankomstTijd, DateTime vertrekTijd)
        {
            this.Naam = naam;
            this.AankomstSpoor = aankomstSpoor;
            this.AankomstTijd = aankomstTijd;
            this.VertrekTijd = vertrekTijd;
        }
    }
}
