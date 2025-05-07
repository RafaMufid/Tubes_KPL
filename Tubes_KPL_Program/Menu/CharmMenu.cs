using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes_KPL_Program.Model;
using Tubes_KPL_Program.Service;

namespace Tubes_KPL_Program.Menu
{
    public static class CharmMenu
    {
        public static async Task Run()
        {
            CharmClient charmAPI = new CharmClient();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Charm Console App ===");
                Console.WriteLine("1. List All Charms");
                Console.WriteLine("2. Add New Charm");
                Console.WriteLine("3. Update Existing Charm");
                Console.WriteLine("4. Delete Charm");
                Console.WriteLine("5. Search Charm by ID");
                Console.WriteLine("0. Exit");
                Console.Write(">> Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await ListCharms(charmAPI);
                        break;

                    case "2":
                        await AddCharm(charmAPI);
                        break;

                    case "3":
                        await UpdateCharm(charmAPI);
                        break;
                    case "4":
                        await DeleteCharm(charmAPI);
                        break;
                    case "5":
                        await SearchCharm(charmAPI);
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

        private static async Task ListCharms(CharmClient apiClient)
        {
            var charms = await apiClient.GetAllCharmsAsync();
            Console.WriteLine("\nCharms List:");
            foreach (var charm in charms)
            {
                Console.WriteLine($"ID: {charm.id} | Name: {charm.name} |  Price: {charm.price} | Effect: {charm.effect}");
            }
            Console.Write("\n>> Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task AddCharm(CharmClient apiClient)
        {
            Console.Write("Enter Charm Name: ");
            var name = Console.ReadLine();
            Console.Write("Enter Charm Price: ");
            int price = int.TryParse(Console.ReadLine(), out var p) ? p : 0;
            Console.Write("Enter Charm Effect: ");
            var effect = Console.ReadLine();

            var newCharm = new Charm
            {
                name = name,
                price = price,
                effect = effect
            };

            var success = await apiClient.AddCharmAsync(newCharm);
            if (success)
                Console.WriteLine(">> Charm added successfully!");
            else
                Console.WriteLine(">> Failed to add charm.");

            Console.Write("\n>> Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task UpdateCharm(CharmClient apiClient)
        {
            Console.Write("Enter Charm ID to Update: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existing = await apiClient.GetCharmByIdAsync(id);
                if (existing != null)
                {
                    Console.WriteLine($"ID: {existing.id} | Name: {existing.name} | Price: {existing.price} | Effect: {existing.effect}");
                    var updatedCharm = GetCharmInput();

                    var success = await apiClient.UpdateCharmAsync(id, updatedCharm);
                    Console.WriteLine(success ? "Charm updated successfully!" : "Failed to update charm.");
                }
                else
                {
                    Console.WriteLine("Charm not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID input.");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private static async Task DeleteCharm(CharmClient apiClient)
        {
            Console.Write("Enter Charm ID to Delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var success = await apiClient.DeleteCharmAsync(id);
                Console.WriteLine(success ? "Charm deleted successfully!" : "Failed to delete charm.");
            }
            else
            {
                Console.WriteLine(">!!!> Invalid ID input.");
            }
            Console.Write("\n> Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task SearchCharm(CharmClient apiClient)
        {
            Console.Write("Enter Charm ID to Search: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var charm = await apiClient.GetCharmByIdAsync(id);
                if (charm != null)
                {
                    Console.WriteLine($"ID: {charm.id} | Name: {charm.name} | Price: {charm.price} | Effect: {charm.effect}");
                }
                else
                {
                    Console.WriteLine("Charm not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID input.");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private static Charm GetCharmInput()
        {
            Console.Write("Enter Charm Name: ");
            var name = Console.ReadLine();
            Console.Write("Enter Charm Price: ");
            int price = int.TryParse(Console.ReadLine(), out var p) ? p : 0;
            Console.Write("Enter Charm Effect: ");
            var effect = Console.ReadLine();

            return new Charm
            {
                name = name ?? "Unknown",
                price = price,
                effect = effect ?? "Unknown"
            };
        }
    }
}
