using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Tubes_KPL_Libraries.Attribute
{
    public class INV<T>
    {
        private List<T> items = new List<T>();
        private string filePath = "inventory.json";

        public void AddItem(T item)
        {
            items.Add(item);
            SaveToJson();
        }

        private void SaveToJson()
        {
            string json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public bool CheckItem(T item)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var loadedItems = JsonSerializer.Deserialize<List<T>>(json);
                if (loadedItems != null)
                {
                    return loadedItems.Contains(item);
                }
            }
            return false;
        }

        public List<T> GetAllItems()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var loadedItems = JsonSerializer.Deserialize<List<T>>(json);
                return loadedItems ?? new List<T>();
            }
            return new List<T>();
        }

        public void ShowInv()
        {
            var allItems = GetAllItems();
            Console.WriteLine("Inventory:");
            foreach (var item in allItems)
            {
                Console.WriteLine("- " + item);
            }
        }
    }
}
