using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht__3
{
    public class Tank : IAttacker
    {
        public void AssignDriver(string driver)
        {
            Console.WriteLine(driver + " is steering the tank");
        }

        public void DriveForward(string positions)
        {
            Console.WriteLine("Tank moves " + positions + " positions forward");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank causes damage");
        }
    }
}
