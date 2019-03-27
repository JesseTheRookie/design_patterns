using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Er is toch maar één shop nodig?
            ComputerShop shop = new ComputerShop();

            Console.WriteLine("[shop creating cheap computers]");
            ComputerFactory lowBudgetComputerFactory = new LowBudgetFactory();
            shop.CreateComputer(lowBudgetComputerFactory);

            Console.WriteLine();

            Console.WriteLine("[shop creating expensive computers]");
            ComputerFactory highBudgetComputerFactory = new HighBudgetFactory();
            shop.CreateComputer(highBudgetComputerFactory);

            Console.ReadKey();
        }
    }
}
