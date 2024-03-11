namespace Aetheria.Engine.Dice
{
    public class DefendAndHealDiceFace : DiceFace
    {
        public override DiceFaceType Type { get => DiceFaceType.DefendAndHeal; }
        public int Block { get; set; }
        public int Heal { get; set; }
        public HealType HealType { get; set; }
    }
}
