using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    interface IHardDisk
    {
        void StoreData();
    }
    interface IMonitor
    {
        void Display();
    }
    interface IProcessor
    {
        void PerformOperation();
    }
}
