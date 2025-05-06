using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tubes_KPL_Program.Model;

namespace Tubes_KPL_Program.Service
{
    class MonsterClient
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl = "https://localhost:7095/api/Monster"; //target url API

        public MonsterClient()
        {
            _client = new HttpClient();
        }

        public async Task<List<Monster>> GetAllMonstersAsync()
        {
            try
            {
                var response = await _client.GetAsync(_baseUrl);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                var monsters = JsonSerializer.Deserialize<List<Monster>>(responseBody, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return monsters ?? new List<Monster>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error fetching monsters: {ex.Message}");
                return new List<Monster>();
            }
        }

        public async Task<bool> AddMonsterAsync(Monster monster)
        {
            try
            {
                var jsonContent = JsonSerializer.Serialize(monster);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync(_baseUrl, content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error adding monster: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateMonsterAsync(int id, Monster updMonster)
        {
            try
            {
                var jsonContent = JsonSerializer.Serialize(updMonster);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _client.PutAsync($"{_baseUrl}/{id}", content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error updating monster: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteMonsterAsync(int id)
        {
            try
            {
                var response = await _client.DeleteAsync($"{_baseUrl}/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error deleting monster: {ex.Message}");
                return false;
            }
        }

        public async Task<Monster?> GetMonsterByIdAsync(int id)
        {
            try
            {
                var response = await _client.GetAsync($"{_baseUrl}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var monster = JsonSerializer.Deserialize<Monster>(responseBody, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    return monster;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error fetching monster by ID: {ex.Message}");
                return null;
            }
        }
    }
}
