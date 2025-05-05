namespace Tubes_KPL_API.Service
{
    using Tubes_KPL_API.Model;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json;
    using System.IO;
    using System.Threading;

    public class MonsterService : IMonsterService
    {
        private readonly string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "monster.json");

        private List<Monster> _monsters;

        public MonsterService()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);
                    _monsters = JsonSerializer.Deserialize<List<Monster>>(json) ?? new List<Monster>();
                    Console.WriteLine($">>Loaded {_monsters.Count} monsters from {filePath}");
                }
                else
                {
                    Console.WriteLine($">!!!> File {filePath} not found. Starting with empty monster list.");
                    _monsters = new List<Monster>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error loading monsters: {ex.Message}");
                _monsters = new List<Monster>();
            }
        }


        private void SaveToFile()
        {
            try
            {
                var json = JsonSerializer.Serialize(_monsters, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
                Console.WriteLine($">>Updated File {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error saving monsters: {ex.Message}");
            }
        }

        public List<Monster> GetAllMonsters()
        {
            return _monsters;
        }

        public Monster GetMonsterById(int id)
        {
            try
            {
                return _monsters.FirstOrDefault(m => m.id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error getting monster by id: {ex.Message}");
                return null;
            }
        }

        public void AddMonster(Monster monster)
        {
            try
            {
                if (monster == null)
                    throw new ArgumentNullException(nameof(monster));

                int newId = _monsters.Any() ? _monsters.Max(m => m.id) + 1 : 1;
                monster.id = newId;
                _monsters.Add(monster);
                SaveToFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error adding monster: {ex.Message}");
            }
        }

        public void UpdateMonster(int id, Monster updatedMonster)
        {
            try
            {
                if (updatedMonster == null)
                    throw new ArgumentNullException(nameof(updatedMonster));

                var monster = GetMonsterById(id);
                if (monster != null)
                {
                    monster.name = updatedMonster.name;
                    monster.health = updatedMonster.health;
                    monster.race = updatedMonster.race;
                    monster.damage = updatedMonster.damage;
                    SaveToFile();
                }
                else
                {
                    Console.WriteLine($">!!!> Monster with id {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error updating monster: {ex.Message}");
            }
        }

        public void DeleteMonster(int id)
        {
            try
            {
                var monster = GetMonsterById(id);
                if (monster != null)
                {
                    _monsters.Remove(monster);
                    SaveToFile();
                }
                else
                {
                    Console.WriteLine($">!!!> Monster with id {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error deleting monster: {ex.Message}");
            }
        }
    }
}
