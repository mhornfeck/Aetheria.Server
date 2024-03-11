namespace Aetheria.Engine.Characters
{
    public struct CharacterAttributes
    {
        public CharacterAttributeValue Strength { get; set; }
        public CharacterAttributeValue Dexterity { get; set; }
        public CharacterAttributeValue Constitution { get; set; }
        public CharacterAttributeValue Wisdom { get; set; }

        public CharacterAttributes()
        {
            Strength = new();
            Dexterity = new();
            Constitution = new();
            Wisdom = new();
        }
    }
}
