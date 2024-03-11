namespace Aetheria.Engine.Dice
{
    public class AttackAndDefendDiceFace : DiceFace
    {
        public override DiceFaceType Type { get => DiceFaceType.AttackAndDefend; }
        public int Damage { get; set; }
        public int Block { get; set; }
    }
}
