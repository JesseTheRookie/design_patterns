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

        public NoCardState(ATMMachine atm)
        {
            this.ATM = atm;
        }

        public void EnterPincode(int pin)
        {
            Console.WriteLine("Please insert your card before entering your pincode");
        }

        public void InsertCard()
        {
            this.ATM.SetMachineState(this.ATM.CardPresent);
        }

        public void RejectCard()
        {
            //Can't reject a card that isn't there
        }

        public void SetAmountInMachine(int amount)
        {
            this.ATM.AmountInMachine = amount;
        }

        public void WithdrawCash(int cash, int amountInMachine)
        {
            throw new NotImplementedException();
        }
    }
}
