using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class Potlood : IPotlood
    {
        private int maxTeSchrijven;
        private int geschrevenKarakters;

        public bool IsScherp {
            get
            {
                if (geschrevenKarakters < maxTeSchrijven)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void NaGeslepen()
        {
            this.geschrevenKarakters = 0;
        }

        public void Schrijf(string boodschap)
        {
            foreach (char c in boodschap)
            {
                if(geschrevenKarakters < maxTeSchrijven)
                {
                    Console.Write(c);
                }
                else
                {
                    Console.Write('#');
                }
                geschrevenKarakters++;
            }
        }
        public Potlood(int max)
        {
            this.maxTeSchrijven = max;
        }
    }
}
