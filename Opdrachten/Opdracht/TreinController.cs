using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht
{
    public class TreinController : ITreinController
    {
        private ITreinReis treinreis;

        public TreinController(ITreinReis treinreis)
        {
            this.treinreis = treinreis;
        }

        public void VolgendeStation()
        {
            treinreis.VolgendeStation();
        }

        public void NieuweDisplay()
        {
            ReisInfoDisplay display = new ReisInfoDisplay(treinreis, this);
            display.Show();
        }
    }
}
