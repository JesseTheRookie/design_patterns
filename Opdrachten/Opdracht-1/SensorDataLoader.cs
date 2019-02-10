using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class SensorDataLoader : BigDataLoader
    {
        public override void Transform()
        {
            Console.WriteLine("Transforming twitter data");
        }
        public override void Extract()
        {
            Console.WriteLine("Extracting twitter data");
        }
        public override void Load()
        {
            Console.WriteLine("Loading twitter data");
        }
    }
}
