using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCompiler
{
    class Sword : PhysicalWeapon
    {
        public Sword(string name, int weight, int value, int physicalDamage, int sharpness) : base(name, weight, value, physicalDamage, sharpness)
        {

        }

        public void Slash()
        {

        }
    }
}
