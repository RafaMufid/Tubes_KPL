namespace Tubes_KPL_API.Service
{
    using Tubes_KPL_API.Model;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json;
    using System.IO;
    using System.Threading;

    public class CharmService : ICharmService
    {
        private readonly string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "charm.json");

        private List<Charm> _charms;

        public CharmService()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);
                    _charms = JsonSerializer.Deserialize<List<Charm>>(json) ?? new List<Charm>();
                    Console.WriteLine($">> Loaded {_charms.Count} charms from {filePath}");
                }
                else
                {
                    Console.WriteLine($">!!!> File {filePath} not found. Starting with empty charms list.");
                    _charms = new List<Charm>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error loading charms: {ex.Message}");
                _charms = new List<Charm>();
            }
        }


        private void SaveToFile()
        {
            try
            {
                var json = JsonSerializer.Serialize(_charms, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
                Console.WriteLine($">> Updated File {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error saving charms: {ex.Message}");
            }
        }

        public List<Charm> GetAllCharms()
        {
            return _charms;
        }

        public Charm GetCharmById(int id)
        {
            try
            {
                return _charms.FirstOrDefault(c => c.id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error getting charm by id: {ex.Message}");
                return null;
            }
        }

        public void AddCharm(Charm charm)
        {
            try
            {
                if (charm == null)
                    throw new ArgumentNullException(nameof(charm));

                int newId = _charms.Any() ? _charms.Max(c => c.id) + 1 : 1;
                charm.id = newId;
                _charms.Add(charm);
                SaveToFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error adding charm: {ex.Message}");
            }
        }

        public void UpdateCharm(int id, Charm updatedCharm)
        {
            try
            {
                if (updatedCharm == null)
                    throw new ArgumentNullException(nameof(updatedCharm));

                var charm = GetCharmById(id);
                if (charm != null)
                {
                    charm.name = updatedCharm.name;
                    charm.price = updatedCharm.price;
                    charm.effect = updatedCharm.effect;
                    SaveToFile();
                }
                else
                {
                    Console.WriteLine($">!!!> Charm with id {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error updating charm: {ex.Message}");
            }
        }

        public void DeleteCharm (int id)
        {
            try
            {
                var charm = GetCharmById(id);
                if (charm != null)
                {
                    _charms.Remove(charm);
                    SaveToFile();
                }
                else
                {
                    Console.WriteLine($">!!!> Charm with id {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error deleting charm: {ex.Message}");
            }
        }
    }
}
