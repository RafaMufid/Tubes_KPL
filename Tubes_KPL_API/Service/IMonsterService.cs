namespace Tubes_KPL_API.Service
{
    using Tubes_KPL_API.Model;
    public interface IMonsterService
    {
        List<Monster> GetAllMonsters();
        Monster GetMonsterById(int id);
        void AddMonster(Monster monster);
        void UpdateMonster(int id, Monster updatedMonster);
        void DeleteMonster(int id);
    }
}
