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

        public CardPresentState(ATMMachine atm)
        {
            this.ATM = atm;
        }

        public void EnterPincode(int pin)
        {
            if (ATM.correctPin == pin)
            {
                Console.WriteLine("You have entered the correct pincode");
                ATM.SetMachineState(ATM.CorrectPinCode);
            }
            else
            {
                Console.WriteLine("Wrong pincode, please try again");
            }
        }
        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            this.ATM.SetMachineState(this.ATM.NoCard);
        }

        public void InsertCard()
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
