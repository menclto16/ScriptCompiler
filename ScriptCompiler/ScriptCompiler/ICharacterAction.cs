using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCompiler
{
    public interface ICharacterAction
    {
        void AddHealth(int input);
        void AddStrength(int input);
        void AddIntelligence(int input);
        void AddSpirit(int input);

        void EquipWeapon(string weaponType, string name, int weight, int value, int attribute1, int attribute2);
        bool EnhanceWeapon();
    }
}
