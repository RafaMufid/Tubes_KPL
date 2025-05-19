using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL_Program.Merchant
{
    public class ItemBuff : IShopItem
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString() => $"{Name} (Harga: {Price})";
    }
}
