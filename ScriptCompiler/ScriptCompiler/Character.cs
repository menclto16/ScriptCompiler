using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCompiler
{
    public class Character : ICharacter
    {
        public int Health;
        public int Strength;
        public int Intelligence;
        public int Spirit;
        public Weapon EquippedWeapon;

        public void EquipWeapon(string weaponType, string name, int weight, int value, int attribute1, int attribute2)
        {
            weaponType = weaponType.ToLower();

            switch (weaponType)
            {
                case "sword":
                    EquippedWeapon = new Sword(name, weight, value, attribute1, attribute2);
                    break;
                case "tome":
                    EquippedWeapon = new Tome(name, weight, value, attribute1, attribute2);
                    break;
                case "staff":
                    EquippedWeapon = new Staff(name, weight, value, attribute1, attribute2);
                    break;
            }
            
        }

        public bool EnhanceWeapon()
        {
            if (EquippedWeapon.EnhancementLevel == 10) return false;

            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 100);
            if (randomNumber < 100 / (EquippedWeapon.EnhancementLevel + 1))
            {
                EquippedWeapon.EnhancementLevel++;
                return true;
            }

            return false;
        }

        public void SetAtributes(int health, int strength, int intelligence, int spirit)
        {
            AddHealth(health);
            AddStrength(strength);
            AddIntelligence(intelligence);
            AddSpirit(spirit);
        }

        public virtual void AddHealth(int input)
        {
            Health += input;
            if (Health > 100) Health = 100;
        }

        public virtual void AddStrength(int input)
        {
            Strength += input;
            if (Strength > 50) Strength = 50;
        }

        public virtual void AddIntelligence(int input)
        {
            Intelligence += input;
            if (Intelligence > 50) Intelligence = 50;
        }

        public virtual void AddSpirit(int input)
        {
            Spirit += input;
            if (Spirit > 50) Spirit = 50;
        }
    }
}
