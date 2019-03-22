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
            HardDisk hardDisk = new HardDisk();
            Monitor monitor = new Monitor();
            Processor processor = new Processor();

            return computerFactory;
        }

        public virtual ComputerFactory MakeComputer() { return new ComputerFactory(); }
        protected virtual IHardDisk MakeHardDisk() { return new HardDisk(); }
        protected virtual IMonitor MakeMonitor() { return new Monitor(); }
        protected virtual IProcessor MakeProcessor() { return new Processor(); } 
    }
}
