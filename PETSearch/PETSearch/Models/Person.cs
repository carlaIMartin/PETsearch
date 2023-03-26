using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PETSearch.Models
{
    public class Person
    {
        [Key] public int Person_Id { get; set; }
        public string Person_Name { get; set; }
        public string Person_Email { get; set;}

        [ForeignKey("Locations")]
        public  string? Location { get; set;}
        public Locations? Locations { get; set; }
        public string Person_Username { get; set; }
        public string Person_Password { get; set; }

        [ForeignKey("Animals")]
        public int? Animal_Id { get; set; }
        public Animals? Animals { get; set; }

        public string Person_Phone_Number { get; set; }

    }
}
