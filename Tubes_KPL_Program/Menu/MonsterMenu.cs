using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes_KPL_Program.Model;
using Tubes_KPL_Program.Service;
using Tubes_KPL_Libraries.Validation;

namespace Tubes_KPL_Program.Menu
{
    public static class MonsterMenu
    {
        public static async Task Run()
        {
            MonsterClient monsterAPI = new MonsterClient();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Monster Console App ===");
                Console.WriteLine("1. List All Monsters");
                Console.WriteLine("2. Add New Monster");
                Console.WriteLine("3. Update Existing Monster");
                Console.WriteLine("4. Delete Monster");
                Console.WriteLine("5. Search Monster by ID");
                Console.WriteLine("0. Exit");
                Console.Write(">> Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await ListMonsters(monsterAPI);
                        break;

                    case "2":
                        await AddMonster(monsterAPI);
                        break;

                    case "3":
                        await UpdateMonster(monsterAPI);
                        break;
                    case "4":
                        await DeleteMonster(monsterAPI);
                        break;
                    case "5":
                        await SearchMonster(monsterAPI);
                        break;

                    case "0":
                        Console.WriteLine("See you later!");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine(">!!!> Invalid option. Try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static async Task ListMonsters(MonsterClient apiClient)
        {
            var monsters = await apiClient.GetAllMonstersAsync();
            Console.WriteLine("\nMonsters List:");
            foreach (var monster in monsters)
            {
                Console.WriteLine($"ID: {monster.id} | Name: {monster.name} | HP: {monster.health} | Race: {monster.race} | Damage: {monster.damage}");
            }
            Console.Write("\n>> Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task AddMonster(MonsterClient apiClient)
        {
            var newMonster = GetMonsterInput();

            var success = await apiClient.AddMonsterAsync(newMonster);
            if (success)
            {
                Console.WriteLine(">> Monster added successfully!");
            }
            else
            {
                Console.WriteLine(">!!!> Failed to add monster.");
            }

            Console.Write("\n>> Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task UpdateMonster(MonsterClient apiClient)
        {
            Console.Write(">> Enter Monster ID to Update: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existing = await apiClient.GetMonsterByIdAsync(id);
                if (existing != null)
                {
                    Console.WriteLine($"Current: {existing.name} | HP: {existing.health} | Race: {existing.race} | Damage: {existing.damage}");
                    var updatedMonster = GetMonsterInput();

                    var success = await apiClient.UpdateMonsterAsync(id, updatedMonster);
                    Console.WriteLine(success ? ">> Monster updated successfully!" : ">!!!> Failed to update monster.");
                }
                else
                {
                    Console.WriteLine(">> Monster not found.");
                }
            }
            else
            {
                Console.WriteLine(">!!!> Invalid ID input.");
            }
            Console.WriteLine("\n>> Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task DeleteMonster(MonsterClient apiClient)
        {
            try
            {
                Console.Write(">> Enter Monster ID to Delete: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    var monster = await apiClient.GetMonsterByIdAsync(id);
                    if (monster == null)
                    {
                        Console.WriteLine(">> Monster not found.");
                    }
                    else
                    {
                        string confirm;
                        do
                        {
                            Console.WriteLine($">> Are you sure you want to delete '{monster.name}'? (Y/N)");
                            confirm = Console.ReadLine()?.Trim().ToUpper();
                            if (confirm != "Y" && confirm != "N")
                            {
                                Console.WriteLine(">> Please enter 'Y' for Yes or 'N' for No.");
                            }
                        } while (confirm != "Y" && confirm != "N");

                        if (confirm == "Y")
                        {
                            var success = await apiClient.DeleteMonsterAsync(id);
                            Console.WriteLine(success ? ">> Monster deleted successfully!" : ">!!!> Failed to delete monster.");
                        }
                        else
                        {
                            Console.WriteLine(">> Delete operation canceled.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine(">!!!> Invalid ID input.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error deleting monster: {ex.Message}");
            }
            Console.Write("\n>> Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task SearchMonster(MonsterClient apiClient)
        {
            Console.Write(">> Enter Monster ID to Search: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var monster = await apiClient.GetMonsterByIdAsync(id);
                if (monster != null)
                {
                    Console.WriteLine($"ID: {monster.id} | Name: {monster.name} | HP: {monster.health} | Race: {monster.race} | Damage: {monster.damage}");
                }
                else
                {
                    Console.WriteLine(">> Monster not found.");
                }
            }
            else
            {
                Console.WriteLine(">!!!> Invalid ID input.");
            }
            Console.WriteLine("\n>> Press any key to continue...");
            Console.ReadKey();
        }

        private static Monster GetMonsterInput()
        {
            string name = ValidateString.GetValidatedString("Monster Name");
            int health = ValidateInt.GetPositiveIntegerInput("Monster Health");
            string race = ValidateString.GetValidatedString("Monster Race");
            int damage = ValidateInt.GetPositiveIntegerInput("Monster Damage");

            return new Monster
            {
                name = name,
                health = health,
                race = race,
                damage = damage
            };
        }
    }
}
