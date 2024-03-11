namespace Aetheria.Engine.Characters
{
    public struct CharacterAttributeValue
    {
        public int Value { get; set; }
        public readonly int Modifier => Value / 5;

        public CharacterAttributeValue()
        {
            Value = 0;
        }
    }
}
