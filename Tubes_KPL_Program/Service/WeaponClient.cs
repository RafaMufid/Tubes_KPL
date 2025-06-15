using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tubes_KPL_Program.Model;

namespace Tubes_KPL_Program.Service
{
    public class WeaponClient
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl = "https://localhost:7095/api/Weapon"; //target url API

        public WeaponClient()
        {
            _client = new HttpClient();
        }

        public async Task<List<Weapon>> GetAllWeaponsAsync()
        {
            try
            {
                var response = await _client.GetAsync(_baseUrl);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                var weapons = JsonSerializer.Deserialize<List<Weapon>>(responseBody, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return weapons ?? new List<Weapon>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error fetching weapons: {ex.Message}");
                return new List<Weapon>();
            }
        }

        public async Task<bool> AddWeaponAsync(Weapon weapon)
        {
            try
            {
                var jsonContent = JsonSerializer.Serialize(weapon);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync(_baseUrl, content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error adding weapon: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateWeaponAsync(int id, Weapon updWeapon)
        {
            try
            {
                var jsonContent = JsonSerializer.Serialize(updWeapon);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _client.PutAsync($"{_baseUrl}/{id}", content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error updating weapon: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteWeaponAsync(int id)
        {
            try
            {
                var response = await _client.DeleteAsync($"{_baseUrl}/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error deleting weapon: {ex.Message}");
                return false;
            }
        }

        public async Task<Weapon?> GetWeaponByIdAsync(int id)
        {
            try
            {
                var response = await _client.GetAsync($"{_baseUrl}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var weapon = JsonSerializer.Deserialize<Weapon>(responseBody, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    return weapon;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error fetching weapon by ID: {ex.Message}");
                return null;
            }
        }
    }
}
