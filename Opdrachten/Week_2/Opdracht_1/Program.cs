using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CallDataLoader callDataLoader = new CallDataLoader();
            SensorDataLoader sensorDataLoader = new SensorDataLoader();
            TwitterDataLoader twitterDataLoader = new TwitterDataLoader();

            BatchProcessor batchProcessor = new BatchProcessor();

            batchProcessor.AddLoader(callDataLoader);
            batchProcessor.AddLoader(sensorDataLoader);
            batchProcessor.AddLoader(twitterDataLoader);

            batchProcessor.ProcessLoaders();

            Console.ReadKey();
        }
    }
}
