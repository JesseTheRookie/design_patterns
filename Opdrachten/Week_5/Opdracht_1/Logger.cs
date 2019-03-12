using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Logger
    {
        public int numberOfLines;
        private static Logger uniqueInstance;
        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Logger(20);

            return uniqueInstance;
        }
        public void Log(string system, string text)
        {
            Console.WriteLine($"[{system}] {text}");
            string x = Console.ReadLine();
            foreach(char c in x)
            {
                numberOfLines--;
            }
        }
        public Logger(int numberOfLines)
        {
            this.numberOfLines = numberOfLines;
        }
    }
}
