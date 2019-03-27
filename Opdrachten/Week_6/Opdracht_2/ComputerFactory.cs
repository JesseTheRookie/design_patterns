using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class ComputerFactory
    {
        //public virtual ComputerShop MakeComputerShop() { return new ComputerShop(); }
        public virtual HardDisk MakeHardDisk() { return new HardDisk(); }
        public virtual Monitor MakeMonitor() { return new Monitor(); }
        public virtual Processor MakeProcessor() { return new Processor(); }
    }
}

