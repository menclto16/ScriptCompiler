using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCompiler
{
    public class Game
    {
        public Character PlayerCharacter;

        public void CreateCharacter(string characterClass)
        {
            characterClass = characterClass.ToLower();

            switch (characterClass)
            {
                case "warrior":
                    PlayerCharacter = new Warrior();
                    break;
                case "mage":
                    PlayerCharacter = new Mage();
                    break;
                case "priest":
                    PlayerCharacter = new Priest();
                    break;
            }
        }
    }
}
