using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boekhandel boekhandel = new Boekhandel();
            Boek boek = new Boek("Tommy wieringa", "Joe Speedboot", 14.5f, 100);
            Weekblad weekblad = new Weekblad("Donderdag", "Historia", 6.5f, 100);
            CD cd = new CD("Tash Sultana", "Jungle", 12.5f, 100);
            boekhandel.VoegToe(boek);
            boekhandel.VoegToe(weekblad);
            boekhandel.VoegToe(cd);

            boekhandel.PrintOverzicht();
            Console.ReadKey();
        }
    }
}
