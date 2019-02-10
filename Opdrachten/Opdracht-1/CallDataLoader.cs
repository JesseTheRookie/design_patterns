using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class CallDataLoader : BigDataLoader
    {
        public override void Transform()
        {
            Console.WriteLine("Transforming call data");
        }
        public override void Extract()
        {
            Console.WriteLine("Extracting call data");
        }
        public override void Load()
        {
            Console.WriteLine("Loading call data");
        }
    }
}
