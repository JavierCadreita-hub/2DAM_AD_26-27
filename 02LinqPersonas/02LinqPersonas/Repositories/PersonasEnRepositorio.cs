using _02LinqPersonas.Models;

namespace _02LinqPersonas.Repositories
{
    public class PersonasEnRepositorio
    {

        public IEnumerable<Persona> getPersonas() {

            return personas;
        
        }

        public IEnumerable<Persona> GetPersonasPorComienzoNombre(string? comienzo)
        {
            if (string.IsNullOrWhiteSpace(comienzo))
            {
                return personas;
            }

            return personas.Where(p =>p.Nombre.StartsWith(comienzo));


        }
        private List<Persona> personas = new List<Persona>{
                new Persona ("Pri", "Primera50Navarra", new DateTime(DateTime.Today.Year - 50,4,3),"Iruñea", "NA", new List<String> {"948121212", "676676676" }),
                new Persona("Seg", "Segunda40Nav", new DateTime( DateTime.Today.Year - 40, 10,3), "Barañain", "NA", new List<string>()),
                new Persona("Ter", "Tercera20Gi", new DateTime( DateTime.Today.Year - 21, 12, 29),  "Donostia", "SS", new List<String> {"943121415"}),
                new Persona("Cua", "Cuarta10NA", new DateTime( DateTime.Today.Year - 10,1,8),  "Barañain", "Na",  new List<String>  {"954534543", "121313657575757", "9345334"}),
                new Persona("Qui","Quinta15Na",  new DateTime( DateTime.Today.Year - 16, 12,28),  "Burlada", "NA", new List<String> {"654534543", "65456546", "69345334"}),
                new Persona("Sex", "Sexta20SS", new DateTime( DateTime.Today.Year - 20, 5,4), "Andoain", "SS"),
                new Persona("Sep", "Septima21SS", new DateTime( DateTime.Today.Year - 22, 12,2),"Hernani", "SS", new List<string>()),
                new Persona("Oct", "Octava23NA", new DateTime( DateTime.Today.Year - 23, 3,6), "Iruñea", "Na"),
                new Persona("Nov", "Novena20Gi", null, "Iruñea", "NA"),
                new Persona("Dec", "Décima20Gi", new DateTime( DateTime.Today.Year - 21, 12, 24),  "Donostia", "SS", new List<string>()),
                 new Persona("Und","Undecima10Na", new DateTime(DateTime.Today.Year -10, 4,23), "Tafalla", "Na"),
                 new Persona("Duo", "Duaodecima0Na",null, "Tafalla","Na")

               };
    }
}
