using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IATMState
    {
        void EnterPincode(int pin);
        void InsertCard();
        void RejectCard();
        void SetAmountInMachine(int amount);
        void WithdrawCash(int cash, int amountInMachine);
    }
}
