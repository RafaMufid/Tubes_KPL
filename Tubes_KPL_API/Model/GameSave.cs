using Tubes_KPL_API.Model;
using Tubes_KPL_API.Service;
namespace Tubes_KPL_API.Model
{
    public class GameSave : IGameSave
    {
        public GameState CreateGameState(string playerName, int idDialog, int idSave)
        {
            return new GameState
            {
                PlayerName = playerName,
                IDDialog = idDialog,
                IDSave = idSave
            };
        }
    }
}
