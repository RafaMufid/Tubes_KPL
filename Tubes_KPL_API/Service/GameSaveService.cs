using System.Text.Json;
using Tubes_KPL_API.Model;

namespace Tubes_KPL_API.Service
{
    public class GameSaveService
    {
        private readonly IGameSave _factory;

        public GameSaveService(IGameSave factory)
        {
            _factory = factory;
        }

        private string GetSaveFilePath(int slot)
        {
            return $"SaveFiles/savegame_slot{slot}.json";
        }

        public GameState? LoadGame(int slot)
        {
            try
            {
                if (slot < 0)
                    throw new ArgumentOutOfRangeException(nameof(slot), "Nomor slot harus bernilai 0 atau lebih.");

                var path = GetSaveFilePath(slot);
                if (!File.Exists(path)) return null;

                var json = File.ReadAllText(path);
                var state = JsonSerializer.Deserialize<GameState>(json);

                if (state == null)
                    throw new InvalidOperationException("Data game gagal dimuat: hasil deserialisasi bernilai null.");

                return state;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[LoadGame] Terjadi kesalahan saat memuat game: {ex.Message}");
                return null; 
            }
        }

        public void SaveGame(string playerName, int idDialog, int slot)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(playerName))
                    throw new ArgumentException("Nama pemain tidak boleh kosong.");

                Directory.CreateDirectory("SaveFiles");
                var gameState = _factory.CreateGameState(playerName, idDialog, slot);
                var json = JsonSerializer.Serialize(gameState, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(GetSaveFilePath(slot), json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SaveGame] Terjadi kesalahan saat menyimpan game: {ex.Message}");
            }
        }

        public bool DeleteSave(int slot)
        {
            try
            {
                if (slot < 0)
                    throw new ArgumentOutOfRangeException(nameof(slot), "Nomor slot harus bernilai 0 atau lebih.");

                var path = GetSaveFilePath(slot);
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteSave] Terjadi kesalahan saat menghapus file: {ex.Message}");
                return false;
            }
        }
    }
}
