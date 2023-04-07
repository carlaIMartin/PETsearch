using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PETSearch.Models
{
    public class Clinics
    {
        [Key] public int Clinic_Id { get; set; }
        public string Clinic_Name { get; set; }

        [ForeignKey("LocationsFKclinics")]
        public string? Location { get; set; }
        public Locations? Locations { get; set; }

    }
}
