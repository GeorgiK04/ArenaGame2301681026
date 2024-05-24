using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal class Bow : Weapon
    {
        const int headshotChance = 1; // random gotta be equal to 1 to be a headshot, headshot is an insta kill
        public override int Attack()
        {

            if (Random.Shared.Next(0, 5) == headshotChance)
            {
                int attack = 500;
                return attack;
            }
            else
            {
                int attack = base.Attack();
                return attack;
            }
        }
    }
}
