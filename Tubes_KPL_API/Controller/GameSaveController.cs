using Microsoft.AspNetCore.Mvc;
using Tubes_KPL_API.Model;
using Tubes_KPL_API.Service;

namespace Tubes_KPL_API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameSaveController : ControllerBase
    {
        private readonly GameSaveService _service;

        public GameSaveController()
        {
            _service = new GameSaveService(new GameSave());
        }

        [HttpGet("{slot}")]
        public ActionResult<GameState> LoadGame(int slot)
        {
            var state = _service.LoadGame(slot);
            if (state == null)
                return NotFound($"Tidak menemukan save file untuk slot {slot}");
            return Ok(state);
        }

        [HttpPost("{slot}")]
        public IActionResult SaveGame(int slot, [FromBody] GameState state)
        {
            _service.SaveGame(state.PlayerName, state.IDDialog, slot);
            return Ok("Game saved berhasil disimpan");
        }

        [HttpDelete("{slot}")]
        public IActionResult DeleteGame(int slot)
        {
            bool deleted = _service.DeleteSave(slot);
            if (!deleted)
                return NotFound($"tidak ditemukan file save {slot} untuk dihapus.");

            return Ok($"Save slot {slot} berhasil dihapus.");
        }

    }
}
