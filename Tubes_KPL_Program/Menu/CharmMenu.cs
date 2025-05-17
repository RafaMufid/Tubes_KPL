using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes_KPL_Libraries.Validation;
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
                Console.WriteLine("====== Charm Compendium ======");
                Console.WriteLine("1. List All Charms");
                Console.WriteLine("2. Add New Charm");
                Console.WriteLine("3. Update Existing Charm");
                Console.WriteLine("4. Delete Charm");
                Console.WriteLine("5. Search Charm by ID");
                Console.WriteLine("0. Back");
                Console.WriteLine("==============================");
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
            var newCharm = GetCharmInput();

            var success = await apiClient.AddCharmAsync(newCharm);
            if (success)
            {
                Console.WriteLine(">> Charm added successfully!");
            }
            else
            {
                Console.WriteLine(">!!!> Failed to add charm.");
            }

            Console.Write("\n>> Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task UpdateCharm(CharmClient apiClient)
        {
            Console.Write(">> Enter Charm ID to Update: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existing = await apiClient.GetCharmByIdAsync(id);
                if (existing != null)
                {
                    Console.WriteLine($"ID: {existing.id} | Name: {existing.name} | Price: {existing.price} | Effect: {existing.effect}");
                    var updatedCharm = GetCharmInput();

                    var success = await apiClient.UpdateCharmAsync(id, updatedCharm);
                    Console.WriteLine(success ? ">> Charm updated successfully!" : ">!!!> Failed to update charm.");
                }
                else
                {
                    Console.WriteLine(">> Charm not found.");
                }
            }
            else
            {
                Console.WriteLine(">!!!> Invalid ID input.");
            }
            Console.WriteLine("\n>> Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task DeleteCharm(CharmClient apiClient)
        {
            try
            {
                Console.Write(">> Enter Charm ID to Delete: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    var charm = await apiClient.GetCharmByIdAsync(id);
                    if (charm == null)
                    {
                        Console.WriteLine(">> Charm not found.");
                    }
                    else
                    {
                        string confirm;
                        do
                        {
                            Console.WriteLine($">> Are you sure you want to delete '{charm.name}'? (Y/N)");
                            confirm = Console.ReadLine()?.Trim().ToUpper();
                            if (confirm != "Y" && confirm != "N")
                            {
                                Console.WriteLine(">> Please enter 'Y' for Yes or 'N' for No.");
                            }
                        } while (confirm != "Y" && confirm != "N");

                        if (confirm == "Y")
                        {
                            var success = await apiClient.DeleteCharmAsync(id);
                            Console.WriteLine(success ? ">> Charm deleted successfully!" : ">!!!> Failed to delete charm.");
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
                Console.WriteLine($">!!!> Error deleting charm: {ex.Message}");
            }
            Console.Write("\n>> Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task SearchCharm(CharmClient apiClient)
        {
            Console.Write(">> Enter Charm ID to Search: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var charm = await apiClient.GetCharmByIdAsync(id);
                if (charm != null)
                {
                    Console.WriteLine($"ID: {charm.id} | Name: {charm.name} | Price: {charm.price} | Effect: {charm.effect}");
                }
                else
                {
                    Console.WriteLine(">> Charm not found.");
                }
            }
            else
            {
                Console.WriteLine(">!!!> Invalid ID input.");
            }
            Console.WriteLine("\n>> Press any key to continue...");
            Console.ReadKey();
        }

        private static Charm GetCharmInput()
        {
            string name = ValidateString.GetValidatedString("Charm Name");
            int price = ValidateInt.GetPositiveIntegerInput("Charm Price");
            string effect = ValidateString.GetValidatedString("Charm Effect");

            return new Charm
            {
                name = name,
                price = price,
                effect = effect
            };
        }
    }
}
