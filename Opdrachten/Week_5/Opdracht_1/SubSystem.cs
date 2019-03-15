using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class SubSystem
    {
        Logger Logger = Logger.GetInstance();

        public void DoSomeMoreWork()
        {
            Logger.Log("Subsystem", "Doing some more work");
        }

        public void DoSomeWork()
        {
            Logger.Log("Subsystem", "Doing some work");
        }
    }
}
