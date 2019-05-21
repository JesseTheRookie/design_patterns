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

        public CorrectPinState(ATMMachine atm)
        {
            this.ATM = atm;
        }

        public void EnterPincode(int pin)
        {
            //this shouldn't be possible
        }

        public void InsertCard()
        {
            throw new NotImplementedException();
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            this.ATM.SetMachineState(this.ATM.NoCard);
        }

        public void SetAmountInMachine(int amount)
        {
            throw new NotImplementedException();
        }

        public void WithdrawCash(int cash, int amountInMachine)
        {
            if(cash < amountInMachine)
            {
                this.ATM.SetAmountInMachine(amountInMachine - cash);
                this.ATM.SetMachineState(this.ATM.NoCard);
            }
            else if (cash == amountInMachine)
            {
                this.ATM.SetAmountInMachine(amountInMachine - cash);
                this.ATM.SetMachineState(this.ATM.NoCash);
            }
            else
            {
                Console.WriteLine("Not enough cash available in the machine");
            }
        }
    }
}
