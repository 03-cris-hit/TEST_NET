using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEST.Contexto;
using TEST.Entidades.Humano;
using TEST.Modelo.Humano;
using TEST.Servicio;

namespace TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HumanoController : ControllerBase
    {
        private readonly FsHumano _fsHumano = new FsHumano(new ApplicationDbContext());

        [HttpGet("ObtenerHumano")]
        public ActionResult<IEnumerable<ModelHumano>> ObtenerObjetoHumano()
        {
            var listHumano = _fsHumano.ObtenerObjetoHumano();
            if (listHumano != null) { 
                return Ok(listHumano);
            }
            return BadRequest("Error contacte con el administrador.");
        }

        [HttpGet("ObtenerListaHumano")]
        public ActionResult<IEnumerable<ModelHumano>> ObtenerListaHumano()
        {
            var listHumano = _fsHumano.ObtenerListaHumano();
            if (listHumano != null)
            {
                return Ok(listHumano);
            }
            return BadRequest("Error contacte con el administrador.");
        }
        [HttpGet("ObtenerHumanoPorId/{id}")]
        public ActionResult<IEnumerable<HumanoEnty>> ObtenerHumanoPorId(int id)
        {
            var humano = _fsHumano.ObtenerHumanoPorId(id);
            if (humano != null)
            {
                return Ok(humano);
            }
            return NotFound();
        }
        [HttpPost("CrearHumano")]
        public ActionResult CrearHumano(HumanoEnty humano)
        {
            var result = _fsHumano.CrearHumano(humano);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPut("ActulizarHumano/{id}")]
        public ActionResult ActulizarHumano([FromBody] HumanoEnty humanoActualizado, int id )
        {

            var result = _fsHumano.ActulizarHumano(humanoActualizado, id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();

        }
    }
}
