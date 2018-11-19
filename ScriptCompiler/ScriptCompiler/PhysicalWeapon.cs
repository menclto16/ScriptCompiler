using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCompiler
{
    class PhysicalWeapon : Weapon
    {
        public int AttackDamage;
        public int Sharpness;

        public PhysicalWeapon(string name, int weight, int value, int attackDamage, int sharpness) : base(name, weight, value)
        {
            AttackDamage = attackDamage;
            Sharpness = sharpness;
        }
    }
}
