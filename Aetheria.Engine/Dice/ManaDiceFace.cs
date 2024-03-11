namespace Aetheria.Engine.Dice
{
    public class ManaDiceFace : DiceFace
    {
        public override DiceFaceType Type { get => DiceFaceType.Mana; }
        public int Mana { get; set; }
    }
}
