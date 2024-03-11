namespace Aetheria.Engine.Dice
{
    public class AttackDiceFace : DiceFace
    {
        public override DiceFaceType Type { get => DiceFaceType.Attack; }
        public int Damage { get; set; }
    }
}
