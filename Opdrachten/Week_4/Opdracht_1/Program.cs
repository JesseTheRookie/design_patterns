using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht__1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>() { new Queen(), new Troll(), new Knight(), new King() };

            foreach(Character character in characters)
            {
                character.Fight();
            }
            Console.WriteLine();

            characters[3].Weapon = new KnifeBehaviour();

            foreach (Character character in characters)
            {
                character.Fight();
            }

            Console.ReadKey();
        }
    }
}
