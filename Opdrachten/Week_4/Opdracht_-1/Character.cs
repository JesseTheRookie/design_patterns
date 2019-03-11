using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht__1
{
    abstract class Character
    {
        public IWeaponBehaviour Weapon { get; set; }

        public Character()
        {
        }
        public void Fight()
        {
            Console.WriteLine(Weapon.UseWeapon());
        }
    }
}
