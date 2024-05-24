using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal class Axe : Weapon
    {
        int Strength = 190;
        int chanceToChopHead = 0;
        public override int Attack()
        {
            if(chanceToChopHead == Random.Shared.Next(0, 11)) // chop enemy's head, insta kill
            {
                return 500;
            }
            else
            {
            return (Strength * Random.Shared.Next(80, 121)) / 100;
            }
        }
    }
}
