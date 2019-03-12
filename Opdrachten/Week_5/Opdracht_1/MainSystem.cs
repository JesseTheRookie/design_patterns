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
        public void DoSomeMainWork(string main, string text)
        {
            Logger.Log(main, text);
        }
        public MainSystem()
        {

        }
    }
}
