using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Tubes_KPL_Program.Model;
using Tubes_KPL_Program.Service;

namespace Tubes_KPL_Program.Battle
{
    public class inventory
    {
        private WeaponClient senjata;
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\data\localItem.json");

        public inventory()
        {
            senjata = new WeaponClient();
            string folderPath = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]"); // default empty list
            }
        }

        public async Task<int> GetWeaponDamage(int id)
        {
            var weapons = await senjata.GetAllWeaponsAsync();
            foreach (var weapon in weapons)
            {
                if (weapon.id == id)
                {
                    return weapon.baseDamage;
                }
            }
            return -1;
        }

        public async Task showItems()
        {
            try
            {
                string json = File.ReadAllText(filePath);
                List<string> LocalItems = JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();

                var apiweapons = await senjata.GetAllWeaponsAsync();

                Console.WriteLine("List of Weapons:");
                bool found = false;

                if (LocalItems.Count == 0)
                {
                    Console.WriteLine(">!!!> Inventory is empty.");
                }

                foreach (var item in LocalItems)
                {
                    Console.WriteLine($"Checking saved item: {item}");
                    var match = apiweapons.FirstOrDefault(w => string.Equals(w.name, item, StringComparison.OrdinalIgnoreCase));

                    if (match != null)
                    {
                        Console.WriteLine($"[{match.id}] Name: {match.name} | Type: {match.type} | Damage: {match.baseDamage}");
                        found = true;
                    }
                    else
                    {
                        Console.WriteLine($">!!!> No matching weapon found for: {item}");
                    }
                }

                if (!found)
                {
                    Console.WriteLine(">!!!> Inventory is empty or no matching weapons found.");
                    Console.ReadKey();
                    Program.Main(new string[] { });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error fetching weapons: {ex.Message}");
            }
        }
    }
}
