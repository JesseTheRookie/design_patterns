using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class CheapComputerFactory : ComputerFactory
    {
        protected override HardDisk MakeHardDisk() { return new CheapHardDisk(); }
        protected override Monitor MakeMonitor() { return new CheapMonitor(); }
        protected override Processor MakeProcessor() { return new CheapProcessor(); }
    }
    class ExpensiveComputerFactory : ComputerFactory
    {
        protected override HardDisk MakeHardDisk() { return new ExpensiveHardDisk(); }
        protected override Monitor MakeMonitor() { return new ExpensiveMonitor(); }
        protected override Processor MakeProcessor() { return new ExpensiveProcessor(); }
    }
}
