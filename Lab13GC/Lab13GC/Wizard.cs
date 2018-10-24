using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13GC
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public Wizard(string Name, int Strength, int Intelligence, int MagicalEnergy, int SpellNumber):base(Name, Strength, Intelligence, MagicalEnergy)
        {
            spellNumber = SpellNumber;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"This Wizard has a number of Spells equal to {spellNumber}.");
        }
    }
}
