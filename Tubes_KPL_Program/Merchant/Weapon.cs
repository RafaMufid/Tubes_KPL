using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL_Program.Merchant
{
    public class Weapon
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Name} (Price: {Price})";
        }
    }
}