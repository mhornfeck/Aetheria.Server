namespace Aetheria.Engine.Dice
{
    public class CharacterDice
    {
        private static readonly Random Random = new();

        public DiceFace[] Faces { get; set; }

        public CharacterDice()
        {
            Faces = new DiceFace[6];
        }

        public DiceFace Roll()
        {
            return Faces[Random.Next(0, 6)];
        }
    }
}
