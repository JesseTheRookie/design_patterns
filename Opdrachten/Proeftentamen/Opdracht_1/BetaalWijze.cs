using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    abstract class BetaalWijze
    {
        protected void InvoerenGegevens()
        {
            Console.WriteLine("Invoeren van gegevens...");
        }
        protected abstract void BetalingVerwerken();
        protected void BevestingMailSturen()
        {
            Console.WriteLine("bevestiging mail versturen...");
        }
        public void Uitvoeren()
        {
            InvoerenGegevens();
            BetalingVerwerken();
            BevestingMailSturen();
        }
    }
}
