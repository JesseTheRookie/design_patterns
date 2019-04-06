using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CorrectPinState : IATMState
    {
        private ATMMachine ATM;
        public CorrectPinState(ATMMachine ATM)
        {
            this.ATM = ATM;
        }

        public void CheckCard()
        {
            throw new NotImplementedException();
        }

        public void CheckCash()
        {
            throw new NotImplementedException();
        }

        public bool CheckPinCode(int pin)
        {
            if(pin == ATM.correctPin)
                return true;
            else
                return false;
        }
    }
}
