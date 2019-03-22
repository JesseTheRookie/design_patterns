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
            ComputerFactory cheapComputerFactory = new CheapComputerFactory();
            cheapComputerFactory.CreateComputer();

            Console.WriteLine();

            Console.WriteLine("[shop creating expensive computers]");
            ComputerFactory expensiveComputerFactory = new ExpensiveComputerFactory();
            expensiveComputerFactory.CreateComputer();

            Console.ReadKey();
        }
    }
}
