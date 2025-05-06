namespace Tubes_KPL_API.Service
{
    using Tubes_KPL_API.Model;
    public interface IWeaponService
    {
        List<Weapon> GetAllWeapons();
        Weapon GetWeaponById(int id);
        void AddWeapon(Weapon weapon);
        void UpdateWeapon(int id, Weapon updatedWeapon);
        void DeleteWeapon(int id);
    }
}
