using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL_Program.Merchant
{
    public interface IShopItem
    {
        int Price { get; }
        string Name { get; }
    }
}
