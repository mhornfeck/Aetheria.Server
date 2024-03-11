namespace Aetheria.Engine.Dice
{
    public class DefendAndManaDiceFace : DiceFace
    {
        public override DiceFaceType Type { get => DiceFaceType.DefendAndMana; }
        public int Block { get; set; }
        public int Mana { get; set; }
    }
}
