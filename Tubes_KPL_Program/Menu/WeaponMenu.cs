using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes_KPL_Program.Model;
using Tubes_KPL_Program.Service;

namespace Tubes_KPL_Program.Menu
{
    public static class WeaponMenu
    {
        public static async Task Run()
        {
            WeaponClient weaponAPI = new WeaponClient();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Weapon Console App ===");
                Console.WriteLine("1. List All Weapons");
                Console.WriteLine("2. Add New Weapon");
                Console.WriteLine("3. Update Existing Weapon");
                Console.WriteLine("4. Delete Weapon");
                Console.WriteLine("5. Search Weapon by ID");
                Console.WriteLine("0. Exit");
                Console.Write(">> Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await ListWeapons(weaponAPI);
                        break;

                    case "2":
                        await AddWeapon(weaponAPI);
                        break;

                    case "3":
                        await UpdateWeapon(weaponAPI);
                        break;
                    case "4":
                        await DeleteWeapon(weaponAPI);
                        break;
                    case "5":
                        await SearchWeapon(weaponAPI);
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

        private static async Task ListWeapons(WeaponClient apiClient)
        {
            var weapons = await apiClient.GetAllWeaponsAsync();
            Console.WriteLine("\nWeapons List:");
            foreach (var weapon in weapons)
            {
                Console.WriteLine($"ID: {weapon.id} | Name: {weapon.name} | Type: {weapon.type} | Price: {weapon.price} | Damage: {weapon.baseDamage}");
            }
            Console.Write("\n>> Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task AddWeapon(WeaponClient apiClient)
        {
            Console.Write("Enter Weapon Name: ");
            var name = Console.ReadLine();
            Console.Write("Enter Weapon Type: ");
            var type = Console.ReadLine();
            Console.Write("Enter Weapon Price: ");
            int price = int.TryParse(Console.ReadLine(), out var p) ? p : 0;
            Console.Write("Enter Weapon Base Damage: ");
            int damage = int.TryParse(Console.ReadLine(), out var d) ? d : 0;

            var newWeapon = new Weapon
            {
                name = name,
                type = type,
                price = price,
                baseDamage = damage
            };

            var success = await apiClient.AddWeaponAsync(newWeapon);
            if (success)
                Console.WriteLine(">> Weapon added successfully!");
            else
                Console.WriteLine(">> Failed to add weapon.");

            Console.Write("\n>> Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task UpdateWeapon(WeaponClient apiClient)
        {
            Console.Write("Enter Weapon ID to Update: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existing = await apiClient.GetWeaponByIdAsync(id);
                if (existing != null)
                {
                    Console.WriteLine($"ID: {existing.id} | Name: {existing.name} | Type: {existing.type} | Price: {existing.price} | Damage: {existing.baseDamage}");
                    var updatedWeapon = GetWeaponInput();

                    var success = await apiClient.UpdateWeaponAsync(id, updatedWeapon);
                    Console.WriteLine(success ? "Weapon updated successfully!" : "Failed to update monster.");
                }
                else
                {
                    Console.WriteLine("Weapon not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID input.");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private static async Task DeleteWeapon(WeaponClient apiClient)
        {
            Console.Write("Enter Weapon ID to Delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var success = await apiClient.DeleteWeaponAsync(id);
                Console.WriteLine(success ? "Weapon deleted successfully!" : "Failed to delete weapon.");
            }
            else
            {
                Console.WriteLine(">!!!> Invalid ID input.");
            }
            Console.Write("\n> Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task SearchWeapon(WeaponClient apiClient)
        {
            Console.Write("Enter Weapon ID to Search: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var weapon = await apiClient.GetWeaponByIdAsync(id);
                if (weapon != null)
                {
                    Console.WriteLine($"ID: {weapon.id} | Name: {weapon.name} | Type: {weapon.type} | Price: {weapon.price} | Damage: {weapon.baseDamage}");
                }
                else
                {
                    Console.WriteLine("Weapon not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID input.");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private static Weapon GetWeaponInput()
        {
            Console.Write("Enter Weapon Name: ");
            var name = Console.ReadLine();
            Console.Write("Enter Weapon Type: ");
            var type = Console.ReadLine();
            Console.Write("Enter Weapon Price: ");
            int price = int.TryParse(Console.ReadLine(), out var p) ? p : 0;
            Console.Write("Enter Weapon Base Damage: ");
            int damage = int.TryParse(Console.ReadLine(), out var d) ? d : 0;

            return new Weapon
            {
                name = name ?? "Unknown",
                type = type ?? "Unknown",
                price = price,
                baseDamage = damage
            };
        }
    }
}
