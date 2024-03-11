using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aetheria.Engine.Characters;
using Aetheria.Engine.Dice;

namespace Aetheria.Engine
{
    public class Battle
    {
        private readonly Party _heroParty;
        private readonly Party _enemyParty;

        public Battle(Party heroParty, Party enemyParty)
        {
            _heroParty = heroParty;
            _enemyParty = enemyParty;
        }

        public void ExecuteDiceAction(Character actor, Character? target, DiceFace diceFace)
        {
            switch (diceFace.Type)
            {   
                case DiceFaceType.Attack:
                    if (target != null)
                    {
                        target.Health -= ((AttackDiceFace) diceFace).Damage;
                    }
                    break;
            }
        }

        private void ExecuteAttack(Character actor, Character target, AttackDiceFace diceFace)
        {
            var damage = diceFace.Damage + actor.Attributes.Strength.Modifier;
            target.Statistics.Health.Value -= damage;
        }
    }
}
