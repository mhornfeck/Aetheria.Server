namespace Aetheria.Engine.Dice
{
    public class DefendDiceFace : DiceFace
    {
        public override DiceFaceType Type { get => DiceFaceType.Defend; }
        public int Block { get; set; }
    }
}
