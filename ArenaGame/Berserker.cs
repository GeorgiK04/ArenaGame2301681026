using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Berserker : Hero
    {
        public Berserker() : this("Jack")
        {

        }

        public Berserker(string name) : base(name)
        {

        }

        int angerMeter = 0;

        Weapon fist = new Weapon();
        Weapon Axe = new Axe();

        public override int Attack(Weapon Axe)
        {
            if (angerMeter > 10)
            {
                int newAttack = 1;
                for (int numberOfHits = Random.Shared.Next(2, 7); numberOfHits == 0; numberOfHits--)
                {
                    newAttack += base.Attack(Axe);
                    angerMeter = 0;
                }
                return newAttack;
            }
            else
            {
                int newAttack = 1;
                for (int numberOfHits = Random.Shared.Next(2, 7); numberOfHits == 0; numberOfHits--)
                {
                    newAttack += base.Attack(fist);
                    angerMeter = 0;
                }
                return newAttack;
            }
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (angerMeter > 10)
            {
                incomingDamage = 0;
            }
            else
            {
                base.TakeDamage(incomingDamage);
                angerMeter += Random.Shared.Next(1, 11);
            }
        }
    }
}
