using System.Collections.Generic;
using _02LinqPersonas.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02LinqPersonas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProvinciasController : ControllerBase
    {
        private readonly ProvinciasEnRepositorio _provincias;

        public ProvinciasController()
        {
            // Nota: En un proyecto real es conveniente inyectar 'Provincias' desde Program.cs / Startup.cs
            _provincias = new ProvinciasEnRepositorio();
        }

        /// <summary>
        /// Obtiene todas las provincias 
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<Provincia>> Get()
        {
            var resultado = _provincias.GetProvincias();
            return Ok(resultado);
        }
        /// <summary>
        /// Obtiene una única provincia según su identificador (ej: /api/provincias/NA).
        /// </summary>
        /// <param name="id">Identificador de la provincia (matrícula provincial).</param>
        /// <returns>La provincia solicitada o un estado 404 Not Found si no existe.</returns>
        [HttpGet("{id}")] // en este caso (parmáetro de ruta) acepta localhost:puerto/api/provincias/NA. El dato NA forma parte de la ruta
        public ActionResult<Provincia> GetProvinciaPorId(string id)
        {
            Provincia? provincia = _provincias.GetProvinciaPorId(id);

            if (provincia == null)
            {
                return NotFound($"No existe ninguna provincia con el identificador '{id}'.");
            }

            return Ok(provincia);
        }
        /// <summary>
        /// Obtiene provincias según los parámetros recibidos.
        /// </summary>
        /// <param name="id">Filtro opcional por identificador único (ej: "NA"). Usa SingleOrDefault.</param>
        /// <param name="nombre">Filtro opcional por inicio del nombre (ej: "Nav").</param>
        [HttpGet("id o Nombre")] // Parámetro de Consulta [FromQuery] o por defecto. El dato se asigna tras ?: localhost:Puerto/api/provincias?id=NA
        public IActionResult Get([FromQuery] string? id = null, [FromQuery] string? nombre = null)
        {
            // 1. Si se proporciona un ID, busca un elemento específico
            if (!string.IsNullOrWhiteSpace(id))
            {
                Provincia? provincia = _provincias.GetProvinciaPorId(id);
                if (provincia == null)
                {
                    return NotFound($"No existe ninguna provincia con el identificador '{id}'.");
                }
                return Ok(provincia);
            }

            // 2. Si no hay ID, devuelve todas o las filtradas por nombre
            var resultado = _provincias.GetProvinciasComienzanPor(nombre);
            return Ok(resultado);
        }
    }
}
