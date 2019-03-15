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
            Console.WriteLine("The pincode is correct");
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

        }
    }
}
