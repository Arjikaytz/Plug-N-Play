using Microsoft.AspNetCore.Mvc;
using PlugAndPlay.Business;
using PlugAndPlay.Common;
using PlugAndPlay.Data; 
using System.Collections.Generic;



namespace PlugAndPlay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GearController : ControllerBase
    {
        private readonly RigManager _manager;

        public GearController()
        {
           
            IGearRepository repo = new DBGearRepository();
            _manager = new RigManager(repo);
        }

        [HttpGet("guitars")]
        public ActionResult<List<GearItem>> GetGuitars()
        {
            return _manager.GetGuitars();
        }

        [HttpGet("pedals")]
        public ActionResult<List<GearItem>> GetPedals()
        {
            return _manager.GetPedals();
        }

        [HttpGet("amplifiers")]
        public ActionResult<List<GearItem>> GetAmplifiers()
        {
            return _manager.GetAmplifiers();
        }

        [HttpPost]
        public ActionResult<string> AddGear([FromBody] GearItem item)
        {
            _manager.AddGear(item);
            return "Gear added successfully.";
        }

        [HttpPut]
        public ActionResult<string> UpdateGear([FromBody] GearItem item)
        {
            _manager.UpdateGear(item);
            return "Gear updated successfully.";
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteGear(int id)
        {
            _manager.DeleteGear(id);
            return $"Gear with ID {id} deleted.";
        }

        [HttpGet("search")]
        public ActionResult<GearItem> SearchGear([FromQuery] string name)
        {
            var result = _manager.SearchGear(name);
            if (result == null)
                return NotFound("Gear not found.");

            return result;
        }


    }
}
