using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCompiler
{
    public class MagicalWeapon : Weapon
    {
        public int MagicalDamage;
        public int MagicalPower;

        public MagicalWeapon(string name, int weight, int value, int magicalDamage, int magicalPower) : base(name, weight, value)
        {
            MagicalDamage = magicalDamage;
            MagicalPower = magicalPower;
        }
    }
}
