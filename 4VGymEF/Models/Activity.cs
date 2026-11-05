using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using _4VGymEF.Validations;

namespace _4VGymEF.Models
{
    public class Activity
    {
        public int Id { get; set; }

        public int? ActivityTypeId { get; set; }

        // Colección de identificadores de instructores que imparten la actividad. ¿Lo necesitaremos ahora? 
        //Con esto al hacer la migracion EF ignora este campo al crear las migraciones de las tablas.
        [NotMapped] 
        public required List<int> InstructorsId { get; set; }

        public int MaxParticipants { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        //Activity // Relación M:N con Instructor
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();


        [ForeignKey(nameof(ActivityTypeId))]

        [JsonIgnore]
        public ActivityType? ActivityType { get; set; }
    }

}
