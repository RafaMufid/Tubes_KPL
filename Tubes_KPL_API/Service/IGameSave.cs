using Tubes_KPL_API.Model;

namespace Tubes_KPL_API.Service
{
    public interface IGameSave
    {
        GameState CreateGameState(string playerName, int idDialog, int idSave);
    }
}
