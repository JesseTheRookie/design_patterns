using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Vliegtuig : IVliegbaar
    {
        //interface methods
        void IVliegbaar.Opstijgen()
        {
            Console.WriteLine("vliegtuig aan het opstijgen");
        }

        void IVliegbaar.Vliegen()
        {
            Console.WriteLine("vliegtuig aan het vliegen");
        }

        void IVliegbaar.Landen()
        {
            Console.WriteLine("vliegtuig aan het landen");
        }
    }
}
