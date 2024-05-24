using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mace : Weapon
    {
        int Strength = 230;
        public override int Attack()
        {
            return (Strength * Random.Shared.Next(80, 121)) / 100;
        }
    }
}
