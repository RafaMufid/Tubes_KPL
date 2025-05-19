using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Tubes_KPL_Libraries.Attribute
{
    public class calculateAttack
    {
        public static readonly Random rng = new Random();

        

        public static int enemyDMG(int health)
        {
            int a = rng.Next(5, 21);
            Console.WriteLine("musuh menyerang dengan damage: " + a);
            return health - a;
            
        }

        public static int getDamage(int health, int dmg) {
            

            Console.WriteLine("damage yang dikeluarkan : " + dmg);
            return health - dmg;
        }

    }
}
