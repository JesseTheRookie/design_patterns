using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class MP3Player : ISubject
    {
        public Nummer HuidigNummer { get; private set; }
        protected List<Nummer> nummers = new List<Nummer>() { new Nummer("Agents Of Fortune", "Blue Öyster Cult"), new Nummer("The Doors", "The Doors"), new Nummer("Unknown Pleasures", "Joy Division"), new Nummer("Telluric", "Matt Corby") };
        private List<IObserver> observers = new List<IObserver>();
        Random rndNummer = new Random();

        public void AddObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(HuidigNummer);
            }
        }

        public void NummerGewijzigd()
        {
            int nummer = rndNummer.Next(nummers.Count);
            this.HuidigNummer = nummers[nummer];
            NotifyObservers();
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }
    }
}
