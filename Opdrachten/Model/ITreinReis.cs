using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;

namespace Model
{
    public interface ITreinReis
    {
        void AddObserver(ITreinDisplay observer);
        void RemoveObserver(ITreinDisplay observer);
        void NotifyObservers();
        void VolgendeStation();
        Station HuidigStation();
    }
}
