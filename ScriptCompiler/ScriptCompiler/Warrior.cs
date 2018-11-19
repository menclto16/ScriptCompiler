using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCompiler
{
    class Warrior : Character
    {
        public Warrior()
        {
            Health = 75;
            Strength = 20;
            Intelligence = 5;
            Spirit = 10;
        }

        public override void AddHealth(int input)
        {
            Health += input;
            if (Health > 150) Health = 150;
        }

        public override void AddStrength(int input)
        {
            Strength += input;
            if (Strength > 75) Strength = 75;
        }
    }
}
