namespace _02LinqPersonas.Models
{
    public class Persona
    {
        /// <summary>
        /// Identificador de la persona. Es único
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Nombre propio, puede contener apellidos
        /// </summary>
        public String Nombre { get; set; } = string.Empty;
        /// <summary>
        /// Fecha de nacimiento
        /// </summary>
        public DateTime? FechaNacimiento { get; set; } = null;
        /// <summary>
        /// Localidad en que vive la persona
        /// </summary>
        public String Localidad { get; set; } = string.Empty;
        /// <summary>
        /// Identificador de la provincia en que vive. Debe ser una provincia existente
        /// </summary>
        public String IdProvincia { get; set; } = string.Empty;

        /// <summary>
        /// Colección de teléfonos. Puede tener de 0 a un número indeterminado. Si no tiene está a null
        /// </summary>
        public List<String>? Telefonos { get; set; } = null;

        /// <summary>
        /// Devuelve la edad actual de la persona. Si no se puede calcular devuelve null
        /// </summary>
        public int? Edad // tipo nulable
        {
            get
            {
                if (FechaNacimiento == null) { return null; }
                if (FechaNacimiento == DateTime.MinValue) return null;
                int ed = DateTime.Today.Year - FechaNacimiento.Value.Year;
                if (ed < 0) return null;
                if (DateTime.Now.Month < FechaNacimiento.Value.Month || (DateTime.Now.Month == FechaNacimiento.Value.Month && DateTime.Now.Day < FechaNacimiento.Value.Day))
                    ed--;
                return ed;
            }
        }
        public Persona() { }

        public Persona(string id)
        {
            Id = id;
        }

        public Persona(string id, string nombre, DateTime? fechaNacimiento, string localidad, string idProvincia) : this(id)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Localidad = localidad;
            IdProvincia = idProvincia;
        }

        public Persona(string id, string nombre, DateTime? fechaNacimiento, string localidad, string idProvincia, List<string> telefonos) : this(id, nombre, fechaNacimiento, localidad, idProvincia)
        {
            Telefonos = telefonos;
        }
    }
}
