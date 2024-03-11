using Aetheria.Engine.Characters;

namespace Aetheria.Engine.Dice
{
    public class DiceFactory
    {
        public CharacterDice GenerateCharacterDice(CharacterClass type)
        {
            switch (type)
            {
                case CharacterClass.Warrior:
                    return GenerateWarriorDice();
                case CharacterClass.Guardian:
                    return GenerateGuardianDice();
                case CharacterClass.Cleric:
                    return GenerateClericDice();
                case CharacterClass.Wizard:
                    return GenerateWizardDice();
                default:
                    throw new ArgumentException("Invalid character type");
            }
        }

        private CharacterDice GenerateWarriorDice()
        {
            return new CharacterDice
            {
                Faces =
                [
                    new AttackDiceFace { Damage = 1 },
                    new AttackDiceFace { Damage = 1 },
                    new AttackDiceFace { Damage = 2 },
                    new AttackDiceFace { Damage = 2 },
                    new DefendDiceFace { Block = 1 },
                    new MissDiceFace()
                ]
            };
        }

        private CharacterDice GenerateGuardianDice()
        {
            return new CharacterDice
            {
                Faces =
                [
                    new AttackDiceFace { Damage = 1 },
                    new DefendDiceFace { Block = 1 },
                    new DefendDiceFace { Block = 1 },
                    new DefendDiceFace { Block = 2 },
                    new DefendDiceFace { Block = 2 },
                    new MissDiceFace()
                ]
            };
        }

        private CharacterDice GenerateClericDice()
        {
            return new CharacterDice
            {
                Faces =
                [
                    new ManaDiceFace { Mana = 1 },
                    new ManaDiceFace { Mana = 1 },
                    new ManaDiceFace { Mana = 2 },
                    new HealDiceFace { Heal = 2, HealType = HealType.SingleTarget },
                    new HealDiceFace { Heal = 2, HealType = HealType.SingleTarget },
                    new MissDiceFace()
                ]
            };
        }

        private CharacterDice GenerateWizardDice()
        {
            return new CharacterDice
            {
                Faces =
                [
                    new ManaDiceFace { Mana = 1 },
                    new ManaDiceFace { Mana = 1 },
                    new ManaDiceFace { Mana = 1 },
                    new ManaDiceFace { Mana = 2 },
                    new ManaDiceFace { Mana = 2 },
                    new MissDiceFace()
                ]
            };
        }
    }
}
