using System;
using System.Collections.Generic;
using System.Text.Json;
using Tubes_KPL_Program.Battle;

namespace Tubes_KPL_Program.Merchant
{
    public class Shop<T>
    {
        private List<T> items = new List<T>();
        public inventory inven = new inventory();
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\data\localItem.json");

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void ShowItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]}");
            }
        }

        public void saveToLocal(string name)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                List<string> LocalItems = JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();

                // Check if item already exists
                if (LocalItems.Any(item => string.Equals(item, name, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"Item {name} sudah ada di inventory.");

                    
                        T RI = items.Find(x => x.Equals(name));
                    
                    RemoveItem(RI);
                }
                else
                {
                    LocalItems.Add(name);
                    Console.WriteLine($"Item {name} berhasil di tambahkan ke dalam inventory.");
                }

                // Save updated list
                string newJson = JsonSerializer.Serialize(LocalItems, new JsonSerializerOptions
                {
                    WriteIndented = true,
                });
                File.WriteAllText(filePath, newJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"gagal melakukan save data items: {ex.Message}");
            }
        }


        public void RemoveItem(T item)
        {
            items.Remove(item);
        }
    }
}
