using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13GC
{
    class GameCharacter
    {
        private string name;
        private int strength;
        private int intelligence;

        public GameCharacter(string Name, int Strength, int Intelligence)
        {
            name = Name;
            strength = Strength;
            intelligence = Intelligence;
        }

        public virtual void Play()
        {
            Console.WriteLine($"This character's name is {name}." +
                $"\nThey have a Strength of {strength}" +
                $" and an Intelligence of {intelligence}.");
        }
    }
}
