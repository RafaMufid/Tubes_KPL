using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL_Program.Menu
{
    class Compendium
    {
        public static async Task Run()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("====== COMPENDIUM ======");
                Console.WriteLine("1. Monsters");
                Console.WriteLine("2. Weapons");
                Console.WriteLine("3. Charms");
                Console.WriteLine("0. Back to Main Menu");
                Console.WriteLine("========================");
                Console.Write(">> Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await MonsterMenu.Run();
                        break;

                    case "2":
                        await WeaponMenu.Run();
                        break;

                    case "3":
                        await CharmMenu.Run();
                        break;

                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine(">!!!> Invalid option. Try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
       
    }
}
