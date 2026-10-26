using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using _4VGymEF.Validations;

namespace _4VGymEF.Models
{
    public class Activity
    {
        public int Id { get; set; }

        public int? ActivityTypeId { get; set; }

        // Colección de identificadores de instructores que imparten la actividad. ¿Lo necesitaremos ahora? 
        public required List<int> InstructorsId { get; set; }

        public int MaxParticipants { get; set; }


        public DateTime DateStart { get; set; }


        public DateTime DateEnd { get; set; }
    }

}
