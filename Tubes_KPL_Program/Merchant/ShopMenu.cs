using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL_Program.Merchant
{
    public class ShopMenu
    {
        Shop<string> shop = new Shop<string>();

        public void showMenu()
        {
            shop.AddItem("Excalibur");
            shop.ShowItems();

            Console.WriteLine("Choose the index of an item to buy: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int index) && index >= 1 && index <= 3)
            {
                string selectedItem = index switch
                {
                    1 => "Excalibur",
                };
                if (selectedItem != null)
                {
                    shop.saveToLocal(selectedItem);
                }
            }
            else
            {
                Console.WriteLine(">!!!> Invalid index.");
            }

            Console.ReadKey();
        }
    }
}
