using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes_KPL_Program.Model;
using Tubes_KPL_Program.Service;

namespace Tubes_KPL_Program.Battle
{
    public class INV
    {
        private WeaponClient senjata;

        public INV()
        {
            senjata = new WeaponClient();
        }

        public async Task showINV()
        {
            var weapons = await senjata.GetAllWeaponsAsync();
            foreach (var weapon in weapons)
            {
                Console.WriteLine($"NO. {weapon.id} | Name: {weapon.name} | Type: {weapon.type} | Damage: {weapon.baseDamage}");
            }
        }

        public async Task<int> GetWeapon(int id)
        {
            var weapons = await senjata.GetAllWeaponsAsync();
            foreach (var weapon in weapons)
            {
                if (weapon.id == id)
                {
                    return weapon.baseDamage;
                }
            }
            return -1;
        }
    }
}
