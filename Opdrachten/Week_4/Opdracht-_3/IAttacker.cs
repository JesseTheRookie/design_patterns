using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht__3
{
    public interface IAttacker
    {
        void AssignDriver(string driver);
        void DriveForward(string steps);
        void UseWeapon();                    
    }
}
