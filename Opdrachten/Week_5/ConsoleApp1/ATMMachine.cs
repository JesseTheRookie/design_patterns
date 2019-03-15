using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ATMMachine
    {
        private IATMState machineState;

        //private bool cardPresent; Overbodig lijkt me
        private int correctPinCode = 1234;
        private bool noCard;
        private bool noCash;

        private double amountInMachine;
        public double AmountInMachine { set { amountInMachine = value; } }
        public ATMMachine(double funds)
        {
            this.AmountInMachine = funds;

            Console.WriteLine("Insert your card, please");
            GetCardPresentState();
            Console.Write("Enter pincode: ");
            int pin = int.Parse(Console.ReadLine());
            EnterPincode(pin);
            Console.WriteLine($"Your funds are {amountInMachine}");
        }
        public void EnterPincode(int pin)
        {
            if(pin == correctPinCode)
            {
                GetCorrectPinState();
            }
            else
            {
                RejectCard();
            }
        }
        public void GetCardPresentState()
        {
            if (!noCard)
            {
                SetMachineState(new CardPresentState(this));
            }
            else
            {
                GetNoCardState();
            }
        }
        public void GetCorrectPinState()
        {
            SetMachineState(new CorrectPinState(this));
        }
        public void GetNoCardState()
        {
            this.noCard = true;
            SetMachineState(new NoCardState(this));
            GetCardPresentState();
        }
        public void GetNoCashState()
        {
            machineState = new NoCashState(this);
        }
        public void InsertCard()
        {
            this.noCard = false;
            GetCardPresentState();
        }
        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected.");
        }
        public void SetAmountInMachine(double funds)
        {
            if(funds == 0)
            {
                GetNoCashState();
            }
            this.AmountInMachine = funds;
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
