namespace Aetheria.Engine.Characters
{
    public struct CharacterStatistics
    {
        public CharacterStatisticValue Health { get; set; }

        public CharacterStatistics()
        {
            Health = new();
        }
    }
}
