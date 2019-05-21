using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ATMMachine atm = new ATMMachine(2000);

            atm.InsertCard();
            atm.RejectCard();

            atm.InsertCard();
            atm.EnterPincode(1234);
            atm.WithdrawCash(1500);

            atm.InsertCard();
            atm.EnterPincode(1234);
            atm.WithdrawCash(750);

            Console.ReadKey();
        }
    }
}
