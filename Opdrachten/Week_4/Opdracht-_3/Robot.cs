using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht__3
{
    public class Robot
    {
        public void BashWithHands()
        {
            Console.WriteLine("Robot bashes with hands");
        }
        public void MoveByPerson(string person)
        {
            Console.WriteLine("Robot is moved by " + person);
        }
        public void WalkForward(string steps)
        {
            Console.WriteLine("Robot walks " + steps + " steps forward");
        }
    }
}
