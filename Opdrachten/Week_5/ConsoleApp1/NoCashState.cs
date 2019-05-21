using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class NoCashState : IATMState
    {
        private ATMMachine ATM;
        public NoCashState(ATMMachine ATM)
        {
            this.ATM = ATM;
        }
        public void EnterPincode(int pin)
        {
            throw new NotImplementedException();
        }

        public void InsertCard()
        {
            throw new NotImplementedException();
        }

        public void RejectCard()
        {
            throw new NotImplementedException();
        }

        public void SetAmountInMachine(int amount)
        {
            throw new NotImplementedException();
        }

        public void WithdrawCash(int cash, int amountInMachine)
        {
            throw new NotImplementedException();
        }
    }
}
