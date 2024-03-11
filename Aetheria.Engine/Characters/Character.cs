using Aetheria.Engine.Dice;

namespace Aetheria.Engine.Characters
{
    public class Character
    {
        private readonly DiceFactory _diceFactory = new();
        private readonly CharacterStatisticsFactory _characterStatisticsFactory = new();

        public string? Name { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public CharacterStatistics Statistics { get; }
        public CharacterAttributes Attributes { get; set; } = new();
        public CharacterDice Dice { get; }

        public bool IsAlive => Statistics.Health.Value > 0;

        public Character(string name, CharacterClass characterClass)
        {
            Name = name;
            CharacterClass = characterClass;

            Dice = _diceFactory.GenerateCharacterDice(characterClass);
            Statistics = _characterStatisticsFactory.GenerateCharacterStatistics(characterClass);
        }
    }
}
