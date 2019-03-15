using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NoCardState : IATMState
    {
        private ATMMachine ATM;
        public NoCardState(ATMMachine ATM)
        {
            this.ATM = ATM;
            Console.WriteLine("No card present");
        }

        public void CheckCard()
        {
            throw new NotImplementedException();
        }

        public void CheckCash()
        {
            throw new NotImplementedException();
        }

        public void CheckPinCode()
        {
            throw new NotImplementedException();
        }
    }
}
