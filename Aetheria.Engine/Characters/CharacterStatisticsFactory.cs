namespace Aetheria.Engine.Characters
{
    public class CharacterStatisticsFactory
    {
        public CharacterStatistics GenerateCharacterStatistics(CharacterClass characterClass)
        {
            switch (characterClass)
            {
                case CharacterClass.Warrior:
                    return new CharacterStatistics
                    {
                        Health = new CharacterStatisticValue(5, 5)
                    };
                case CharacterClass.Guardian:
                    return new CharacterStatistics
                    {
                        Health = new CharacterStatisticValue(6, 6)
                    };
                case CharacterClass.Cleric:
                    return new CharacterStatistics
                    {
                        Health = new CharacterStatisticValue(5, 5)
                    };
                case CharacterClass.Wizard:
                    return new CharacterStatistics
                    {
                        Health = new CharacterStatisticValue(4, 4)
                    };
                default:
                    throw new ArgumentException("Invalid character type");
            }
        }
    }
}
