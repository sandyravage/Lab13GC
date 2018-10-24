using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13GC
{
    class Warrior : GameCharacter
    {
        private string weaponType;

        public Warrior(string Name, int Strength, int Intelligence, string WeaponType):base(Name, Strength, Intelligence)
        {
            weaponType = WeaponType;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"This Warrior uses a {weaponType} as a weapon.");
        }
    }
}
