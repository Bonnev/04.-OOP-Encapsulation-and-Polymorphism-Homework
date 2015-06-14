using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Items;

namespace TheSlum.GameEngine
{
    class CustomEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    this.PrintCharactersStatus(this.characterList);
                    break;
                case "create":
                    this.characterList.Add(CreateCharacter(inputParams));
                    break;
                case "add":
                    GetCharacterById(inputParams[1]).AddToInventory(CreateItem(inputParams));
                    break;
            }
        }

        private new Character CreateCharacter(string[] inputParams)
        {
            switch (inputParams[1].ToLower())
            {
                case "warrior":
                    return new Warrior(inputParams[2],
                        Int32.Parse(inputParams[3]),
                        Int32.Parse(inputParams[4]),
                        (Team)Enum.Parse(typeof(Team),
                        inputParams[5], true));
                case "mage":
                    return new Mage(inputParams[2],
                        Int32.Parse(inputParams[3]),
                        Int32.Parse(inputParams[4]),
                        (Team)Enum.Parse(typeof(Team),
                        inputParams[5], true));
                case "healer":
                    return new Healer(inputParams[2],
                        Int32.Parse(inputParams[3]),
                        Int32.Parse(inputParams[4]),
                        (Team)Enum.Parse(typeof(Team),
                        inputParams[5], true));
            }
            return null;
        }

        private new Item CreateItem(string[] inputParams)
        {
            switch (inputParams[2].ToLower())
            {
                case "axe":
                    return new Axe(inputParams[3]);
                case "shield":
                    return new Shield(inputParams[3]);
                case "injection":
                    return new Injection(inputParams[3]);
                case "pill":
                    return new Pill(inputParams[3]);
            }
            return null;
        }
    }
}
