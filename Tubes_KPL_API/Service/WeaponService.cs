namespace Tubes_KPL_API.Service
{
    using Tubes_KPL_API.Model;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json;
    using System.IO;
    using System.Threading;

    public class WeaponService : IWeaponService
    {
        private readonly string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "weapon.json");

        private List<Weapon> _weapons;

        public WeaponService()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);
                    _weapons = JsonSerializer.Deserialize<List<Weapon>>(json) ?? new List<Weapon>();
                    Console.WriteLine($">> Loaded {_weapons.Count} weapons from {filePath}");
                }
                else
                {
                    Console.WriteLine($">!!!> File {filePath} not found. Starting with empty weapons list.");
                    _weapons = new List<Weapon>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error loading weapons: {ex.Message}");
                _weapons = new List<Weapon>();
            }
        }


        private void SaveToFile()
        {
            try
            {
                var json = JsonSerializer.Serialize(_weapons, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
                Console.WriteLine($">> Updated File {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error saving weapons: {ex.Message}");
            }
        }

        public List<Weapon> GetAllWeapons()
        {
            return _weapons;
        }

        public Weapon GetWeaponById(int id)
        {
            try
            {
                return _weapons.FirstOrDefault(w => w.id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error getting weapon by id: {ex.Message}");
                return null;
            }
        }

        public void AddWeapon(Weapon weapon)
        {
            try
            {
                if (weapon == null)
                    throw new ArgumentNullException(nameof(weapon));

                int newId = _weapons.Any() ? _weapons.Max(w => w.id) + 1 : 1;
                weapon.id = newId;
                _weapons.Add(weapon);
                SaveToFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error adding monster: {ex.Message}");
            }
        }

        public void UpdateWeapon(int id, Weapon updatedWeapon)
        {
            try
            {
                if (updatedWeapon == null)
                    throw new ArgumentNullException(nameof(updatedWeapon));

                var monster = GetWeaponById(id);
                if (monster != null)
                {
                    monster.name = updatedWeapon.name;
                    monster.type = updatedWeapon.type;
                    monster.price = updatedWeapon.price;
                    monster.baseDamage = updatedWeapon.baseDamage;
                    SaveToFile();
                }
                else
                {
                    Console.WriteLine($">!!!> Weapon with id {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error updating weapon: {ex.Message}");
            }
        }

        public void DeleteWeapon(int id)
        {
            try
            {
                var weapon = GetWeaponById(id);
                if (weapon != null)
                {
                    _weapons.Remove(weapon);
                    SaveToFile();
                }
                else
                {
                    Console.WriteLine($">!!!> Weapon with id {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error deleting weapon: {ex.Message}");
            }
        }
    }
}
