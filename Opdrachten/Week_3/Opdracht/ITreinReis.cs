using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht
{
    public interface ITreinReis
    {
        void VolgendeStation();
        void AddObserver(ITreinDisplay display);
        void RemoveObserver(ITreinDisplay display);
    }
}
