using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ATMMachine
    {
        private int amountInMachine;
        public int AmountInMachine { set { amountInMachine = value; } }

        public int correctPin = 1234;

        private IATMState machineState;

        //private CardPresentState cardPresent = new CardPresentState(this); Mag dit niet omdat ik een object meegeef aan een andere class?
        private CardPresentState cardPresent;
        private CorrectPinState correctPinCode;
        private NoCardState noCard;
        private NoCashState noCash;

        public CardPresentState CardPresent { get { return cardPresent; } private set { cardPresent = new CardPresentState(this); } }
        public CorrectPinState CorrectPinCode { get { return correctPinCode; } private set { correctPinCode = new CorrectPinState(this); } }
        public NoCardState NoCard { get { return noCard; } private set { noCard = new NoCardState(this); } }
        public NoCashState NoCash { get { return noCash; } private set { noCash = new NoCashState(this); } }

        public ATMMachine(int initialFunds)
        {
            this.machineState = this.NoCard;
            this.machineState.SetAmountInMachine(initialFunds);
        }

        public void EnterPincode(int pin)
        {
            this.machineState.EnterPincode(pin);
        }

        public void InsertCard()
        {
            this.SetMachineState(this.CardPresent);
        }
        public void RejectCard()
        {
            this.machineState.RejectCard();
        }
        public void SetAmountInMachine(int funds)
        {
            this.machineState.SetAmountInMachine(funds);
        }
        public void SetMachineState(IATMState state)
        {
            this.machineState = state;
        }
        public void WithdrawCash(int amount)
        {
            this.machineState.WithdrawCash(amount, amountInMachine);
        }
    }
}
