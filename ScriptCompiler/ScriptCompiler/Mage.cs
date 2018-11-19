using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCompiler
{
    public class Mage : Character
    {
        public Mage()
        {
            Health = 50;
            Strength = 5;
            Intelligence = 15;
            Spirit = 15;
        }

        public override void AddIntelligence(int input)
        {
            Intelligence += input;
            if (Intelligence > 75) Intelligence = 75;
        }

        public override void AddSpirit(int input)
        {
            Spirit += input;
            if (Spirit > 75) Spirit = 75;
        }
    }
}
