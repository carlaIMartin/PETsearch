using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PETSearch.Models
{
    public class Animals
    {
        // hello world
        [Key] public int Animal_Id { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }
        public string Height { get; set; }
        public string Species { get; set; }

        [ForeignKey("Person")]
        public int? Person_Id { get; set; }
        public Person? Person { get; set; }

        [ForeignKey("Locations")]
        public string? Location { get; set; }
        public Locations? Locations { get; set; }

        [ForeignKey("Clinics")]
        public int? Clinic_Id { get; set; }
        public Clinics? Clinics { get; set; }

    }
}
