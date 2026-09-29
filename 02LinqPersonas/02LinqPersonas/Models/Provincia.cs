namespace _02LinqPersonas.Models
{
    public class Provincia
    {
        public String Id { get; set; } = string.Empty;
        public String Nombre { get; set; } = String.Empty;

        public Provincia() { }
        public Provincia(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
       
    }
}
