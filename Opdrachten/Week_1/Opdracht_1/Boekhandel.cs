using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Boekhandel
    {
        private List<BoekHandelItem> BoekHandelItems { get; set; }
        public Boekhandel()
        {
            this.BoekHandelItems = new List<BoekHandelItem>();
        }
        public void VoegToe(BoekHandelItem item)
        {
            this.BoekHandelItems.Add(item);
        }
        public void PrintOverzicht()
        {
            foreach(BoekHandelItem item in this.BoekHandelItems)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
