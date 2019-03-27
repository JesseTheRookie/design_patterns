using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class JukeBox
    {
        public List<IVinylSingle> Singles { get; set; }
        public IVinylSingle CurrentSingle { get; set; } 
        public JukeBox(List<IVinylSingle> singles)
        {
            this.Singles = singles;
        }
        public void Afspelen()
        {
            this.CurrentSingle.Play();
        }
        public void SelectSingle(int index)
        {
            this.CurrentSingle = Singles[index];
        }
    }
}
