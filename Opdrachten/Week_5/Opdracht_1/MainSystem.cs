using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class MainSystem 
    {
        Logger Logger = Logger.GetInstance();
        SubSystem SubSystem = new SubSystem();

        protected void DoSomeMainWork()
        {
            Logger.Log("Main", "doing some main work");
        }

        public MainSystem()
        {
            DoSomeMainWork();
            SubSystem.DoSomeMoreWork();
            SubSystem.DoSomeWork();
        }
    }
}
