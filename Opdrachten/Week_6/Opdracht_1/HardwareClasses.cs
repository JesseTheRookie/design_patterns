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
        public void StoreData()
        {
            Console.WriteLine("Storing data");
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
    //Cheap hardware
    public class CheapHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Storing data not so quickly");
        }
    }
    public class CheapMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Displaying stuff poorly");
        }
    }
    public class CheapProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing operation not so quick");
        }
    }
    //Expensive hardware
    public class ExpensiveHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Storing data very quick");
        }
    }
    public class ExpensiveMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Displaying stuff very nice");
        }
    }
    public class ExpensiveProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing operation very quick");
        }
    }
}
