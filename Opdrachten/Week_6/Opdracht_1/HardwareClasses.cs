using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    //Default hardware
    public class HardDisk : IHardDisk
    {
        public virtual void StoreData()
        {
            Console.WriteLine("Storing data");
        }
    }
    public class Monitor : IMonitor
    {
        public virtual void Display()
        {
            Console.WriteLine("Displaying stuff");
        }
    }
    public class Processor : IProcessor
    {
        public virtual void PerformOperation()
        {
            Console.WriteLine("Processing stuff");
        }
    }
    //Cheap hardware
    public class CheapHardDisk : HardDisk
    {
        public override void StoreData()
        {
            Console.WriteLine("Storing data not so quickly");
        }
    }
    public class CheapMonitor : Monitor
    {
        public override void Display()
        {
            Console.WriteLine("Displaying stuff poorly");
        }
    }
    public class CheapProcessor : Processor
    {
        public override void PerformOperation()
        {
            Console.WriteLine("Performing operation not so quick");
        }
    }
    //Expensive hardware
    public class ExpensiveHardDisk : HardDisk
    {
        public override void StoreData()
        {
            Console.WriteLine("Storing data very quick");
        }
    }
    public class ExpensiveMonitor : Monitor
    {
        public override void Display()
        {
            Console.WriteLine("Displaying stuff very nice");
        }
    }
    public class ExpensiveProcessor : Processor
    {
        public override void PerformOperation()
        {
            Console.WriteLine("Performing operation very quick");
        }
    }
}
