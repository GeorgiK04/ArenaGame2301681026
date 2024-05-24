using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Archer : Hero
    {
        const int headshotChance = 1; // random gotta be equal to 1 to be a headshot, headshot is an insta kill
        public Archer() : this("Robin")
        {

        }

        public Archer(string name) : base(name)
        {

        }

        Weapon fist = new Weapon();
        Weapon Bow = new Bow();

        public override int Attack(Weapon Bow)
        {

            if(Random.Shared.Next(0, 5) == headshotChance)
            {
                int attack = 500;
                return attack;
            }
            else
            {
                int attack = base.Attack(fist);
                return attack;
            }
        }

        public override void TakeDamage(int incomingDamage)
        {
            if(Random.Shared.Next(0,20) == 1)
            {
                incomingDamage *= 2;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
