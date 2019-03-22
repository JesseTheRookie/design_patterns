using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class ComputerFactory
    {
        public ComputerFactory CreateComputer()
        {
            ComputerFactory computerFactory = MakeComputer();
            HardDisk hardDisk = MakeHardDisk();
            Monitor monitor = MakeMonitor();
            Processor processor = MakeProcessor();

            hardDisk.StoreData();
            monitor.Display();
            processor.PerformOperation();

            return computerFactory;
        }

        protected virtual ComputerFactory MakeComputer() { return new ComputerFactory(); }
        protected virtual HardDisk MakeHardDisk() { return new HardDisk(); }
        protected virtual Monitor MakeMonitor() { return new Monitor(); }
        protected virtual Processor MakeProcessor() { return new Processor(); } 
    }
}
