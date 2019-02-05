using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class PotloodSlijper : IPotloodSlijper
    {
        public void Slijp(IPotlood potlood)
        {
            potlood.NaGeslepen();
        }
    }
}
