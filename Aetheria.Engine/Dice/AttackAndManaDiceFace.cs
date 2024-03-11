namespace Aetheria.Engine.Dice
{
    public class AttackAndManaDiceFace : DiceFace
    {
        public override DiceFaceType Type { get => DiceFaceType.AttackAndMana; }
        public int Damage { get; set; }
        public int Mana { get; set; }
    }
}
