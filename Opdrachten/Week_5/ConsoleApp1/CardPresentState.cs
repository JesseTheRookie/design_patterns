using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CardPresentState : IATMState
    {
        private ATMMachine ATM;
        public CardPresentState(ATMMachine ATM)
        {
            this.ATM = ATM;
        }

        public void CheckCard()
        {
            
        }

        public void CheckCash()
        {
            ATM.GetNoCashState();
        }

        public void CheckPinCode()
        {
            ATM.GetCorrectPinState();  
        }
    }
}
