using _4VGymAPI.Models;
using _4VGymAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _4VGymAPI.Controllers
{
    [ApiController]
    [Route("instructors")]
    public class InstructorsController : ControllerBase
    {
        private readonly InMemoryInstructorRepository _repository;

        // Inyectamos la clase concreta del repositorio
        public InstructorsController(InMemoryInstructorRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// GET /instructor
        /// GET /instructor?first_initial=M
        /// Devuelve el listado de monitores (filtrado opcionalmente por la inicial del nombre)
        /// </summary>
        /// <param name="firstInitial">Filtro opcional para la inicial del monitor</param>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Instructor>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<Instructor>> FindInstructors([FromQuery(Name = "first_initial")] string? firstInitial)
        {
            try
            {
                IEnumerable<Instructor> instructors = _repository.GetByFirstInitial(firstInitial);

                return Ok(instructors);
            }
            catch (Exception)
            {
                return BadRequest(new ErrorResponse(1, "Any problem in the Server"));
            }
        }


        // GET: api/instructors/2
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(Instructor), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        public ActionResult<Instructor> GetInstructorById([FromRoute] int id)
        {
            try
            {
                Instructor? instructor = _repository.GetById(id);
                //Instructor? instructor = _repository.GetByIdLinq(id)
                if (instructor != null)
                {
                    return Ok(instructor);
                }
                return NotFound(new ErrorResponse(2, $"No existe el instructor {id}"));

            }
            catch (Exception)
            {

                return BadRequest(new ErrorResponse(1, "Ocurrió un error en el servidor al procesar la solicitud."));
            }

        }

    }
}
