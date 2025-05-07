namespace Tubes_KPL_API.Service
{
    using Tubes_KPL_API.Model;
    public interface ICharmService
    {
        List<Charm> GetAllCharms();
        Charm GetCharmById(int id);
        void AddCharm(Charm charm);
        void UpdateCharm(int id, Charm updatedCharm);
        void DeleteCharm(int id);
    }
}
