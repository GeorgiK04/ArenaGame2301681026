using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Cleric : Hero
    {
        int numberOfAttacksMade = 1;

        public Cleric() : this("Jesus")
        {

        }

        public Cleric(string name) : base(name)
        {

        }

        Weapon fist = new Weapon();
        Weapon Mace = new Mace();

        public override int Attack(Weapon Mace)
        {
            if (numberOfAttacksMade % 10 == 0)
            {
                Heal(50);
                numberOfAttacksMade++;
            }
            else
            {
                numberOfAttacksMade++;
            }
            return base.Attack(fist);
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (Random.Shared.Next(0, 101) > 10)
            {
                incomingDamage /= 2;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
