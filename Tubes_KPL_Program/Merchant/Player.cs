using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL_Program.Merchant
{
    public class Player
    {
        public int Gold { get; set; }
        public Inventory<Weapon> Inventory { get; set; } = new Inventory<Weapon>();

        public Player(int gold)
        {
            Gold = gold;
        }

        public void BuyItem(Weapon item)
        {
            Gold -= item.Price;
            Inventory.AddItem(item);
        }
    }
}
