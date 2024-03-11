namespace Aetheria.Engine.Dice
{
    public class AttackAndHealDiceFace : DiceFace
    {
        public override DiceFaceType Type { get => DiceFaceType.AttackAndHeal; }
        public int Damage { get; set; }
        public int Heal { get; set; }
        public HealType HealType { get; set; }
    }
}
