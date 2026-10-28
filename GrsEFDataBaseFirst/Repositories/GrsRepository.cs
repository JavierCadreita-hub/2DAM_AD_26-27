using GrsEFDataBaseFirst.Data;
using GrsEFDataBaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace GrsEFDataBaseFirst.Repositories
{
    public class GrsRepository
    {
        // _bdGrsContext será la instancia que sirve de puente entre el repositorio y la base de datos. Permite consultar y manipular las tablas (Grs, Etapas, Zonas, etc.) usando LINQ y EF Core
        private readonly BdGrsContext _bdGrsContext;

        public GrsRepository(BdGrsContext bdGrsContext)
        {
            _bdGrsContext = bdGrsContext;
        }
        public async Task<List<Gr>> GetGrs() // Carga de forma asíncrona sin datos relacionados
        {
            return await _bdGrsContext.Grs.ToListAsync();
        }


    }
}
