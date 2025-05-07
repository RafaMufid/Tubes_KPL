using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tubes_KPL_Program.Model;

namespace Tubes_KPL_Program.Service
{
    class CharmClient
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl = "https://localhost:7095/api/Charm"; //target url API

        public CharmClient()
        {
            _client = new HttpClient();
        }

        public async Task<List<Charm>> GetAllCharmsAsync()
        {
            try
            {
                var response = await _client.GetAsync(_baseUrl);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                var charms = JsonSerializer.Deserialize<List<Charm>>(responseBody, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return charms ?? new List<Charm>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error fetching charms: {ex.Message}");
                return new List<Charm>();
            }
        }

        public async Task<bool> AddCharmAsync(Charm charm)
        {
            try
            {
                var jsonContent = JsonSerializer.Serialize(charm);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync(_baseUrl, content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error adding charm: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateCharmAsync(int id, Charm updCharm)
        {
            try
            {
                var jsonContent = JsonSerializer.Serialize(updCharm);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _client.PutAsync($"{_baseUrl}/{id}", content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error updating charm: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteCharmAsync(int id)
        {
            try
            {
                var response = await _client.DeleteAsync($"{_baseUrl}/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error deleting charm: {ex.Message}");
                return false;
            }
        }

        public async Task<Charm?> GetCharmByIdAsync(int id)
        {
            try
            {
                var response = await _client.GetAsync($"{_baseUrl}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var charm = JsonSerializer.Deserialize<Charm>(responseBody, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    return charm;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">!!!> Error fetching charm by ID: {ex.Message}");
                return null;
            }
        }
    }
}
