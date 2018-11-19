using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCompiler
{
    class Priest : Character
    {
        public Priest()
        {
            Health = 40;
            Strength = 5;
            Intelligence = 10;
            Spirit = 20;
        }

        public override void AddHealth(int input)
        {
            Health += input;
            if (Health > 75) Health = 75;
        }

        public override void AddSpirit(int input)
        {
            Spirit += input;
            if (Spirit > 100) Spirit = 100;
        }

    }
}
