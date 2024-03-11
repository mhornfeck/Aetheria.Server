using Aetheria.Engine.Characters;

namespace Aetheria.Engine
{
    public class PartyFactory
    {
        public Party GenerateHeroParty()
        {
            return new Party
            {
                Characters =
                [
                    new("Warrior", CharacterClass.Warrior),
                    new("Guardian", CharacterClass.Guardian),
                    new("Cleric", CharacterClass.Cleric),
                    new("Wizard", CharacterClass.Wizard)
                ]
            };
        }
    }
}
