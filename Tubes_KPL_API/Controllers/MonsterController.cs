namespace Tubes_API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Tubes_KPL_API.Model;
    using Tubes_KPL_API.Service;
    using System.Collections.Generic;

    [ApiController]
    [Route("api/[controller]")]
    public class MonsterController : ControllerBase
    {
        private readonly IMonsterService _monsterService;

        public MonsterController(IMonsterService monsterService)
        {
            _monsterService = monsterService;
        }

        [HttpGet]
        public ActionResult<List<Monster>> GetAll()
        {
            return _monsterService.GetAllMonsters();
        }

        [HttpGet("{id}")]
        public ActionResult<Monster> GetById(int id)
        {
            var monster = _monsterService.GetMonsterById(id);
            if (monster == null)
            {
                return NotFound();
            }
            return monster;
        }

        [HttpPost]
        public ActionResult Create(Monster monster)
        {
            _monsterService.AddMonster(monster);
            return CreatedAtAction(nameof(GetById), new { id = monster.id }, monster);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Monster updatedMonster)
        {
            var existing = _monsterService.GetMonsterById(id);
            if (existing == null)
            {
                return NotFound();
            }
            _monsterService.UpdateMonster(id, updatedMonster);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existing = _monsterService.GetMonsterById(id);
            if (existing == null)
            {
                return NotFound();
            }
            _monsterService.DeleteMonster(id);
            return NoContent();
        }
    }
}
