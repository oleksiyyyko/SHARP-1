using Microsoft.AspNetCore.Mvc;
using webAPI.Models;
using webAPI.Models.DTO;
using webAPI.Data;
using System.Linq;

namespace webAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public WeatherForecastController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<ModelsDTO>> GetModels()
        {
            return Ok(_db.Players);
            // return Ok(ModelStore.ModelDTOs);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Player> GetModels(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            //var villa = ModelsStore.ModelDTOs.FirstOrDefault(u => u.Id == id);
             var player = _db.Players.FirstOrDefault(u => u.Id==id);
            if (player == null)
            {
                return BadRequest();
            }
            return Ok(player);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Player> CreatePlayer([FromBody] Player ModelsDTO)
        {
            if (ModelsDTO == null)
            {
                return BadRequest(ModelsDTO);
            }
            if (ModelsDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            ModelsDTO.Name = ModelsDTO.Name + "test";
            _db.Players.Add(ModelsDTO);

            _db.SaveChanges();

            return Ok(ModelsDTO);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Player> DeletePlayer(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var player = _db.Players.FirstOrDefault(u => u.Id == id);
            if (player == null)
            {
                return NotFound();
            }

            _db.Players.Remove(player);
            _db.SaveChanges();

            return Ok();
        }

    }
}
