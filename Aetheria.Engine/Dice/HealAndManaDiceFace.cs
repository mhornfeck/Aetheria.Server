namespace Aetheria.Engine.Dice
{
    public class HealAndManaDiceFace : DiceFace
    {
        public override DiceFaceType Type { get => DiceFaceType.HealAndMana; }
        public int Heal { get; set; }
        public HealType HealType { get; set; }
        public int Mana { get; set; }
    }
}
