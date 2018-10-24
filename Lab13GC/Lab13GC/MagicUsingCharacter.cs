using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13GC
{
    class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;

        public MagicUsingCharacter(string Name, int Strength, int Intelligence, int MagicalEnergy):base(Name, Strength, Intelligence)
        {
            magicalEnergy = MagicalEnergy;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"This Magic User has a Magical Energy level of {magicalEnergy}.");
        }
    }
}
