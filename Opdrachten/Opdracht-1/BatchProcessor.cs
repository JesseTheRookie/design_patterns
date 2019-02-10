using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class BatchProcessor
    {
        private List<BigDataLoader> bigDataLoaders = new List<BigDataLoader>();
        public void AddLoader(BigDataLoader bigDataLoader)
        {
            bigDataLoaders.Add(bigDataLoader);
        }
        public void ProcessLoaders()
        {
            foreach(BigDataLoader bigDataLoader in bigDataLoaders)
            {
                Console.WriteLine("[ETL-process started]");
                bigDataLoader.Extract();
                bigDataLoader.Transform();
                bigDataLoader.Load();
                Console.WriteLine("[ETL-proces finished]");
                Console.WriteLine();
            }
        }
    }
}
