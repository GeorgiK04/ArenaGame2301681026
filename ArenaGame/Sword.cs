using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Sword : Weapon
    {
        int Strength = 190;
        public virtual int Attack()
        {
            int chanceToPierce = 0;
            if (chanceToPierce == Random.Shared.Next(0,8)) // pierce is just double damage
            {
                return ((Strength * Random.Shared.Next(80, 121)) / 100)*2;
            }
            else
            {
               return (Strength * Random.Shared.Next(80, 121)) / 100;
            }
            
        }
    }
}
