using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ATMMachine
    {

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

        private double amountInMachine;
        public double AmountInMachine { set { amountInMachine = value; } }

        public int correctPin = 1234;

        private IATMState machineState;

        private CardPresentState CardPresent { get { return CardPresent; } set { GetCardPresentState(); } }
        private CorrectPinState CorrectPinCode { get { return CorrectPinCode; } set { GetCorrectPinState(); } }
        private NoCardState NoCard { get { return NoCard; } set { GetNoCardState(); } }
        private NoCashState NoCash { get { return NoCash; } set { GetNoCashState(); } }


        public void EnterPincode(int pin)
        {
            if (CorrectPinCode.CheckPinCode(pin))
            {
                machineState = CorrectPinCode;
            }
        }
        public CardPresentState GetCardPresentState()
        {
            return new CardPresentState(this);
        }
        public CorrectPinState GetCorrectPinState()
        {
            return new CorrectPinState(this);
        }
        public NoCardState GetNoCardState()
        {
            return new NoCardState(this);
        }
        public NoCashState GetNoCashState()
        {
            return new NoCashState(this);
        }
        public void InsertCard()
        {
            /*this.noCard = false;
            GetCardPresentState();*/
        }
        public void RejectCard()
        {
            //Console.WriteLine("Your card has been rejected.");
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
