using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            tank.AssignDriver("Dave");

            Robot robot = new Robot();
            robot.MoveByPerson("Pieter");

            RobotAdapter robotAdapter = new RobotAdapter(robot);

            List<IAttacker> attackers = new List<IAttacker>() { tank, robotAdapter };

            foreach(IAttacker attacker in attackers)
            {
                attacker.DriveForward("3");
                attacker.UseWeapon();
            }

            Console.ReadKey();
        }
    }
}
