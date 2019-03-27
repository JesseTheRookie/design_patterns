using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class LowBudgetFactory : ComputerFactory
    {
        public override HardDisk MakeHardDisk() { return new CheapHardDisk(); }
        public override Monitor MakeMonitor() { return new CheapMonitor(); }
        public override Processor MakeProcessor() { return new CheapProcessor(); }
    }
    class HighBudgetFactory : ComputerFactory
    {
        public override HardDisk MakeHardDisk() { return new ExpensiveHardDisk(); }
        public override Monitor MakeMonitor() { return new ExpensiveMonitor(); }
        public override Processor MakeProcessor() { return new ExpensiveProcessor(); }
    }
}
