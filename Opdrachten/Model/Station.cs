using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Station : IObserver
    {
        public string Naam { get; set; }
        public string AankomstSpoort { get; set; }
        public DateTime AankomstTijd { get; set; }
        public DateTime VertrekTijd { get; set; }
        public Station(string naam, string aankomstSpoor, DateTime aankomstTijd, DateTime vertrekTijd)
        {
            this.Naam = naam;
            this.AankomstSpoort = aankomstSpoor;
            this.AankomstTijd = aankomstTijd;
            this.VertrekTijd = vertrekTijd;
        }

        public void Update(Station station)
        {
            throw new NotImplementedException();
        }
    }
}
