using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TreinReis : ITreinReis
    {
        private List<Station> stations;
        private int huidigStation;

        public TreinReis()
        {
            stations = new List<Station>() { new Station("Haarlem", "1", new DateTime(2019, 2, 24, 13, 0 , 0), new DateTime(2019, 2, 24, 13, 15, 0)),
                new Station("Amsterdam", "3", new DateTime(2019, 2, 24, 14, 0, 0), new DateTime(2019, 2, 24, 14, 15, 0)),
                new Station("Leiden", "5", new DateTime(2019, 2, 24, 15, 0 , 0), new DateTime(2019, 2, 24, 15, 15, 0))};
            huidigStation = 0;
        }

        public void AddObserver(Station observer)
        {
            stations.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach(Station station in stations)
            {
                station.Update(station);
            }
        }

        public void RemoveObserver(Station observer)
        {
            stations.Remove(observer);
        }

        public void VolgendeStation()
        {
           this.huidigStation++;
        }
        public Station HuidigStation()
        {
            return stations[huidigStation];
        }
    }
}
