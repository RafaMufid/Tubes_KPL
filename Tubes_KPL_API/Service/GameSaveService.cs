using System.Text.Json;
using Tubes_KPL_API.Model;

namespace Tubes_KPL_API.Service
{
    public class GameSaveService
    {
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
                return null; // Atau bisa lempar ulang jika ingin dibiarkan naik ke controller
            }
        }

        public void SaveGame(GameState state, int slot)
        {
            try
            {
                if (state == null)
                    throw new ArgumentNullException(nameof(state), "Data game tidak boleh null.");

                if (slot < 0)
                    throw new ArgumentOutOfRangeException(nameof(slot), "Nomor slot harus bernilai 0 atau lebih.");

                if (string.IsNullOrWhiteSpace(state.PlayerName))
                    throw new ArgumentException("Nama pemain tidak boleh kosong.", nameof(state.PlayerName));

                Directory.CreateDirectory("SaveFiles");
                var json = JsonSerializer.Serialize(state, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(GetSaveFilePath(slot), json);

                if (!File.Exists(GetSaveFilePath(slot)))
                    throw new InvalidOperationException("Gagal menyimpan game: file tidak berhasil dibuat.");
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
