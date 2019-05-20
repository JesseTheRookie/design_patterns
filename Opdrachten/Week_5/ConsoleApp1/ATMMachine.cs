using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ATMMachine
    {
        private double amountInMachine;
        public double AmountInMachine { set { amountInMachine = value; } }

        public int correctPin = 1234;

        private IATMState machineState;

        private CardPresentState CardPresent { get { return CardPresent; } set { new CardPresentState(this); } }
        private CorrectPinState CorrectPinCode { get { return CorrectPinCode; } set { new CorrectPinState(this); } }
        private NoCardState NoCard { get { return NoCard; } set { new NoCardState(this); } }
        private NoCashState NoCash { get { return NoCash; } set { new NoCashState(this); } }

        public ATMMachine()
        {
            this.machineState = NoCard;

            /*
            Console.WriteLine("Insert your card, please");
            CardPresent.CheckCard();
            Console.Write("Enter pincode: ");
            int pin = int.Parse(Console.ReadLine());
            EnterPincode(pin);
            Console.WriteLine($"Your funds are {amountInMachine}");
            */
        }

        public void EnterPincode(int pin)
        {
            this.machineState.CheckPinCode();
        }

        public void InsertCard()
        {
            SetMachineState(CardPresent);
        }
        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
        }
        public void SetAmountInMachine(double funds)
        {
            if(funds > 0)
            {
                this.AmountInMachine = funds;
            }
            else
            {
                this.machineState = NoCash;
            }            
        }
        public void SetMachineState(IATMState state)
        {
            this.machineState = state;
        }
        public void WithdrawCash(int amount)
        {
            if(amount > amountInMachine)
            {
                Console.WriteLine($"The money in the machine is {amountInMachine}. Please, try again");
            }
            else
            {
                Console.WriteLine($"{amount} has been withdrawn from machine.");
            }
        }
    }
}
