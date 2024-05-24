using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal class Katana : Weapon
    {
        int Strength = 200;
        int chanceToBleed = 0;
        public override int Attack()
        {
            if (chanceToBleed == Random.Shared.Next(0, 6)) //cause bleeding
            {
                return ((Strength * Random.Shared.Next(80, 121)) / 100) + 300;
            }
            else
            {
                return (Strength * Random.Shared.Next(80, 121)) / 100;
            }
        }
    }
}
