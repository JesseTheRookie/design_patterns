using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Logger
    {
        public int numberOfLines = 1;
        private static Logger uniqueInstance;
        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Logger();

            return uniqueInstance;
        }
        public void Log(string system, string text)
        {
            Console.WriteLine($" {numberOfLines} - [{system}] {text}");
            numberOfLines++;
        }
        private Logger()
        {
            
        }
    }
}
