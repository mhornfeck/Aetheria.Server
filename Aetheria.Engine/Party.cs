using Aetheria.Engine.Characters;

namespace Aetheria.Engine
{
    public class Party
    {
        public List<Character> Characters { get; set; }

        public Party()
        {
            Characters = [];
        }

        public Party(List<Character> characters)
        {
            Characters = characters;
        }
    }
}
