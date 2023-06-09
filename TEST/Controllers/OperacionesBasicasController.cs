using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEST.Modelo.Operador;
using TEST.Servicio;

namespace TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesBasicasController : ControllerBase
    {
        private readonly FsOperaciones _fsOperaciones = new FsOperaciones();
        [HttpPost("PostOperaciones")]
        public ActionResult<int> OperacionesMatematicasMetodoPost(ModelOperacion operacion)
        {
            string response = _fsOperaciones.OperacionesMatematicasPorModelo(operacion);
            int numero;
            if (int.TryParse(response, out numero))
            {
                return Ok(numero);
            }
            else
            {
                return BadRequest(response);
            }
        }
        [HttpGet("GetOperaciones")]
        public ActionResult<int> OperacionesMatematicasMetodoGet()
        {
            if (Request.Headers.TryGetValue("Numero1", out var numero1HeaderValue) &&
            Request.Headers.TryGetValue("Numero2", out var numero2HeaderValue) &&
            Request.Headers.TryGetValue("Operador", out var operadorHeaderValue))
            {
                if (int.TryParse(numero1HeaderValue, out int numero1) &&
                    int.TryParse(numero2HeaderValue, out int numero2))
                {
                    string response = _fsOperaciones.OperacionesMatematicasPorPametro(numero1,numero2,operadorHeaderValue);
                    int numero;
                    if (int.TryParse(response, out numero))
                    {
                        return Ok(numero);
                    }
                    else
                    {
                        return BadRequest(response);
                    }
                }
                else
                {
                    return BadRequest("Los valores en los encabezados no son números válidos");
                }
            }
            else
            {
                return BadRequest("Faltan los encabezados necesarios");
            }
        }
    }
}
