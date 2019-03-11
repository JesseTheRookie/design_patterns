using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Superman : IVliegbaar
    {
        void IVliegbaar.Opstijgen()
        {
            Console.WriteLine("superman aan het opstijgen");
        }

        void IVliegbaar.Vliegen()
        {
            Console.WriteLine("superman lekker aan het rondvliegen");
        }

        void IVliegbaar.Landen()
        {
            Console.WriteLine("superman aan het landen");
        }
    }
}
