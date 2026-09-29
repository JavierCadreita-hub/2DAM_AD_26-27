using _02LinqPersonas.Models;
using _02LinqPersonas.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _02LinqPersonas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonasController : ControllerBase
    {
        private PersonasEnRepositorio _personas = new PersonasEnRepositorio();

        [HttpGet("personasComienzoNombre")]
        public ActionResult<IEnumerable<Persona>> GetPersonasPorComienzoNombre([FromQuery] string? texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return Ok(_personas.GetPersonasPorComienzoNombre(texto));
            }

            var resultado = _personas.GetPersonasPorComienzoNombre(texto);
            return Ok(resultado);
        }

        [HttpGet("personasComienzoTipoAnonimo")]
        public IActionResult GetPersonasPorComienzoNombreAnonimo([FromQuery] string? texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return BadRequest("Debe proporcionar un texto de búsqueda.");
            }

            var resultado = _personas.GetPersonasPorComienzoNombre(texto)
                .Select(p => new
                {
                    p.Nombre,
                    p.Edad
                });

            return Ok(resultado);
        }
    }
}
