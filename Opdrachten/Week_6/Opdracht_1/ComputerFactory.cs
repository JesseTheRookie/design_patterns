using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    abstract class ComputerFactory
    {
        protected abstract IHardDisk MakeHardDisk();

        protected virtual IMonitor MakeMonitor()
        {
            return new Monitor();
        }
        protected abstract IProcessor MakeProcessor();
    
    }
    public class HardDisk : IHardDisk
    {
        public virtual void StoreData()
        {
            Console.WriteLine("Stores data");
        }
    }
    public class Monitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Displaying stuff");
        }
    }
    public class Processor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Processing stuff");
        }
    }
}
