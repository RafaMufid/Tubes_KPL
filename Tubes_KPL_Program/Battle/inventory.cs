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

        public async Task<string> GetWeaponNames()
        {
            try
            {
                string json = File.ReadAllText(filePath);
                List<string> LocalItems = JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();

                var apiweapons = await senjata.GetAllWeaponsAsync();

                foreach (string item in LocalItems)
                {
                    var match = apiweapons.FirstOrDefault(w => string.Equals(w.name, item, StringComparison.OrdinalIgnoreCase));

                    if (match != null)
                    {
                        var weaponInfo = $"[{match.id}] Name: {match.name} | Type: {match.type} | Damage: {match.baseDamage}";
                        return weaponInfo; // return the first matching weapon info
                    }
                }

                return null; // explicitly return null if no match is found
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return null; // ensure all code paths return a value
        }

        public async Task<int> GetWeaponDamage(string name)
        {
            var weapons = await senjata.GetAllWeaponsAsync();
            foreach (var weapon in weapons)
            {
                if (weapon.name.ToLower() == name.ToLower())
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

                Console.WriteLine("senjata yang ada:");
                bool found = false;

                if (LocalItems.Count == 0)
                {
                    Console.WriteLine("Inventory kosong");
                }

                foreach (var item in LocalItems)
                {
                    var match = apiweapons.FirstOrDefault(w => string.Equals(w.name, item, StringComparison.OrdinalIgnoreCase));

                    if (match != null)
                    {
                        Console.WriteLine($"[{match.id}] Name: {match.name} | Type: {match.type} | Damage: {match.baseDamage}");
                        found = true;
                    }
                    else
                    {
                        Console.WriteLine($"tidak ada yang cocok dengan: {item}");
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Inventory kosong atau item tidak ditemukan");
                    Console.ReadKey();
                    Program.Main(new string[] { });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"gagal mengambil data items: {ex.Message}");
            }
        }
    }
}
