using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCompiler
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Value { get; set; }
        public int EnhancementLevel { get; set; }

        public Weapon(string name, int weight, int value)
        {
            Name = name;
            Weight = weight;
            Value = value;
            EnhancementLevel = 0;
        }

        public string GetName()
        {
            return Name + " +" + EnhancementLevel;
        }

        public virtual void Attack()
        {

        }
    }
}
