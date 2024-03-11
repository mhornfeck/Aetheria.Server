namespace Aetheria.Engine.Dice
{
    public class HealDiceFace : DiceFace
    {
        public override DiceFaceType Type { get => DiceFaceType.Heal; }
        public int Heal { get; set; }
        public HealType HealType { get; set; }
    }
}
