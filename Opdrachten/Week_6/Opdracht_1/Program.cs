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
            Console.WriteLine("[shop creating cheap computers]");
            ComputerShop cheapComputerFactory = new CheapComputerShop();
            cheapComputerFactory.CreateComputer();

            Console.WriteLine();

            Console.WriteLine("[shop creating expensive computers]");
            ComputerShop expensiveComputerFactory = new ExpensiveComputerShop();
            expensiveComputerFactory.CreateComputer();

            Console.ReadKey();
        }
    }
}
