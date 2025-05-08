using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL_Libraries.Attribute
{
    public class AttackCal
    {
        public static readonly Random rng = new Random();
        public INV<string> kecil = new INV<string>();

        public void konekInv() {
            kecil.GetAllItems();
        }
        
        public static int Heals(string Dhel)
        {
            string[] nameHer = { "yukki", "nino" };
            string[] nameHels = { "holy heals", "potion of heals" };
            int[] heals = { 20, 10 };
            int maxlength = nameHels.Length;

            int ch = 0;
            for (int i = 0; i < nameHer.Length; i++) {
                if (Dhel == nameHer[i]) {
                    ch = heals[i];
                    return ch;
                }
            }
            return ch;
        }
        public static int Damage(string Daction)
        {
            string[] weapon = { "sword", "spear", "hammer", "fireball"};
            string[] actions = { "slash", "pierce", "strike", "magic"};
            int[] damage = { 10, 15, 5, 20};
            int maxlength = actions.Length;

            int cd = 0;
            for (int i = 0; i < weapon.Length; i++)
            {
                if (Daction == weapon[i])
                {
                    cd = damage[i];
                    return cd;
                }
            }
            return cd;
        }
        public static int enemyDMG(int health)
        {
            int a = rng.Next(5, 21);
            Console.WriteLine("musuh menyerang dengan damage: " + a);
            return health - a;
            
        }

        public static int getDamage(int health, string name) {
            int dmg = Damage(name);

            Console.WriteLine("damage yang dikeluarkan : " + dmg);
            return health - dmg;
        }

        public static int getHeal(int health, string name) {
            int heals = Heals(name);

            Console.WriteLine("heals yang dilakukan sebesar: " + heals);
            return health + heals;
            
            
        }
    }
}
