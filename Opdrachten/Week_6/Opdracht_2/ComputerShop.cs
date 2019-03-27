using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class ComputerShop
    {
        public void CreateComputer(ComputerFactory computerFactory)
        {
            /* Moet de computershop worden gereturned?
            ComputerShop computerShop = computerFactory.MakeComputerShop();
            */

            HardDisk hardDisk = computerFactory.MakeHardDisk();
            Monitor monitor = computerFactory.MakeMonitor();
            Processor processor = computerFactory.MakeProcessor();

            hardDisk.StoreData();
            monitor.Display();
            processor.PerformOperation();

            //return computerShop;
        }
    }
}
