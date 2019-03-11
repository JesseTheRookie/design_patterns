using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht__3
{
    public class RobotAdapter : IAttacker
    {
        private Robot robot;

        public RobotAdapter(Robot robot)
        {
            this.robot = robot;
        }

        public void AssignDriver(string driver)
        {
            this.robot.MoveByPerson(driver);
        }

        public void DriveForward(string steps)
        {
            this.robot.WalkForward(steps);
        }

        public void UseWeapon()
        {
            this.robot.BashWithHands();
        }
    }
}
