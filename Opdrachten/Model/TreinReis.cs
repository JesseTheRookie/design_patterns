using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;

namespace Model
{
    public class TreinReis : ITreinReis
    {
        private List<Station> stations;
        private int huidigStation;
        private List<ITreinDisplay> treinDisplays = new List<ITreinDisplay>();

        public TreinReis()
        {
            stations = new List<Station>() { new Station("Haarlem", "1", new DateTime(2019, 2, 24, 13, 0 , 0), new DateTime(2019, 2, 24, 13, 15, 0)),
                new Station("Amsterdam", "3", new DateTime(2019, 2, 24, 14, 0, 0), new DateTime(2019, 2, 24, 14, 15, 0)),
                new Station("Leiden", "5", new DateTime(2019, 2, 24, 15, 0 , 0), new DateTime(2019, 2, 24, 15, 15, 0))};
            huidigStation = 0;
        }

        public void AddObserver(ITreinDisplay observer)
        {
            treinDisplays.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach(ITreinDisplay treinDisplay in treinDisplays)
            {
                treinDisplay.Update();
            }
        }

        public void RemoveObserver(ITreinDisplay observer)
        {
            treinDisplays.Remove(observer);
        }

        public void VolgendeStation()
        {
            int stationAantal = stations.Count;
            if(stationAantal > stationAantal++)
            {
                this.huidigStation++;
            }
            else
            {
                this.huidigStation = 0;
            }
        }
        public Station HuidigStation()
        {
            return stations[huidigStation];
        }
    }
}
