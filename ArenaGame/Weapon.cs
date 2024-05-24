using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Weapon
    {
        int Strength = 100;
        public virtual int Attack()
        {
            return (Strength * Random.Shared.Next(80, 121)) / 100;
        }
    }
}
