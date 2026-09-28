using _4VGymAPI.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace _4VGymAPI.Repositories
{
    public class InMemoryInstructorRepository
    {
        private Dictionary<long, Instructor> _instructors = new();
        public InMemoryInstructorRepository()
        {
            SeedData(); // Precargamos algunos datos de prueba
        }
        private void SeedData()
        {

            Instructor insMiguel = new Instructor { Id = 1, Name = "Miguel Goyena", Email = "miguel_goyena@cuatrovientos.org", Phone = "654121212", PhotoUrl = "https://img.magnific.com/vector-premium/imagen-perfil-avatar-hombre-aislada-fondo-imagen-profil-avatar-hombre_1293239-4841.jpg?semt=ais_hybrid&w=740&q=80" };
            _instructors.Add(insMiguel.Id, insMiguel);
            Instructor insMaria = new Instructor { Id = 2, Name = "María Martín", Email = "maria_martin@cuatrovientos.org", Phone = "663423121", PhotoUrl = "https://img.magnific.com/vector-premium/avatar-mujer-sonriente_937492-6135.jpg?semt=ais_hybrid&w=740&q=80" };
            _instructors.Add(insMaria.Id, insMaria);
            Instructor insIban = new Instructor { Id = 3, Name = "Iban Sarría", Email = "iban_sarria@cuatrovientos.org", Phone = "654646464", PhotoUrl = "https://img.magnific.com/vector-premium/imagen-perfil-avatar-hombre-aislada-fondo-imagen-profil-avatar-hombre_1293239-4861.jpg?semt=ais_hybrid&w=740&q=80" };
            _instructors.Add(insIban.Id, insIban);

        }

        // Método para obtener todos los instructores
        public IEnumerable<Instructor> GetAll()
        {
            return _instructors.Values;
        }
    }
}
