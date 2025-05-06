namespace Tubes_API.Controller
{
    using Microsoft.AspNetCore.Mvc;
    using Tubes_KPL_API.Model;
    using Tubes_KPL_API.Service;
    using System.Collections.Generic;

    [ApiController]
    [Route("api/[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;

        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpGet]
        public ActionResult<List<Weapon>> GetAll()
        {
            return _weaponService.GetAllWeapons();
        }

        [HttpGet("{id}")]
        public ActionResult<Weapon> GetById(int id)
        {
            var weapon = _weaponService.GetWeaponById(id);
            if (weapon == null)
            {
                return NotFound();
            }
            return weapon;
        }

        [HttpPost]
        public ActionResult Create(Weapon weapon)
        {
            _weaponService.AddWeapon(weapon);
            return CreatedAtAction(nameof(GetById), new { id = weapon.id }, weapon);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Weapon updatedWeapon)
        {
            var existing = _weaponService.GetWeaponById(id);
            if (existing == null)
            {
                return NotFound();
            }
            _weaponService.UpdateWeapon(id, updatedWeapon);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existing = _weaponService.GetWeaponById(id);
            if (existing == null)
            {
                return NotFound();
            }
            _weaponService.DeleteWeapon(id);
            return NoContent();
        }
    }
}
