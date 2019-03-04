using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht__1
{
    class Knight : Character
    {
        public Knight()
        {
            this.Weapon = new SwordBehaviour();
        }
    }
}
