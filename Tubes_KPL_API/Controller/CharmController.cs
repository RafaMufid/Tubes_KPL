namespace Tubes_API.Controller
{
    using Microsoft.AspNetCore.Mvc;
    using Tubes_KPL_API.Model;
    using Tubes_KPL_API.Service;
    using System.Collections.Generic;

    [ApiController]
    [Route("api/[controller]")]
    public class CharmController : ControllerBase
    {
        private readonly ICharmService _charmService;

        public CharmController(ICharmService charmService)
        {
            _charmService = charmService;
        }

        [HttpGet]
        public ActionResult<List<Charm>> GetAll()
        {
            return _charmService.GetAllCharms();
        }

        [HttpGet("{id}")]
        public ActionResult<Charm> GetById(int id)
        {
            var charm = _charmService.GetCharmById(id);
            if (charm == null)
            {
                return NotFound();
            }
            return charm;
        }

        [HttpPost]
        public ActionResult Create(Charm charm)
        {
            _charmService.AddCharm(charm);
            return CreatedAtAction(nameof(GetById), new { id = charm.id }, charm);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Charm updatedCharm)
        {
            var existing = _charmService.GetCharmById(id);
            if (existing == null)
            {
                return NotFound();
            }
            _charmService.UpdateCharm(id, updatedCharm);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existing = _charmService.GetCharmById(id);
            if (existing == null)
            {
                return NotFound();
            }
            _charmService.DeleteCharm(id);
            return NoContent();
        }
    }
}
