using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13GC
{
    class Program
    {
        public static GameCharacter[] gameCharacters = {
            new Warrior("Gargamel \"Big Easy\" Chopkins", 12, 9, "Battleaxe" ),
            new Warrior("Portauk, Destroyer of Worlds",13,8,"Turkey Baster"),
            new Wizard("Pookums",7,14,5,10),
            new Wizard("Leaflet Bunnawalskioversmith",7,15,6,11),
            new Wizard("Lazer Blazer-McPhaser",6,14,6,9)
            };

        static void Main()
        {
            foreach(GameCharacter character in gameCharacters)
            {
                character.Play();
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

    }
}
