using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ITreinReis
    {
        void AddObserver(Station observer);
        void RemoveObserver(Station observer);
        void NotifyObservers();
        void VolgendeStation();
    }
}
