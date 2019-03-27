using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class ComputerShop
    {
        public ComputerShop CreateComputer()
        {
            ComputerShop computerFactory = MakeComputer();
            HardDisk hardDisk = MakeHardDisk();
            Monitor monitor = MakeMonitor();
            Processor processor = MakeProcessor();

            hardDisk.StoreData();
            monitor.Display();
            processor.PerformOperation();

            return computerFactory;
        }

        protected virtual ComputerShop MakeComputer() { return new ComputerShop(); }
        protected virtual HardDisk MakeHardDisk() { return new HardDisk(); }
        protected virtual Monitor MakeMonitor() { return new Monitor(); }
        protected virtual Processor MakeProcessor() { return new Processor(); } 
    }
}
