namespace Aetheria.Engine.Characters
{
    public struct CharacterStatisticValue
    {
        public int Value { get; set; }
        public int MaximumValue { get; set; }

        public CharacterStatisticValue(int value, int maximumValue)
        {
            Value = value;
            MaximumValue = maximumValue;
        }
    }
}
