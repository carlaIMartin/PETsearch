using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PETSearch.Models
{
    public class Vets
    {
        //HELLO WORLDF
        [Key] public int Vet_Id { get; set; }

        public string Vet_Name { get; set; }

        public string Vet_Email { get; set; }

        public string Vet_Phone_Number { get; set; }

        [ForeignKey("ClinicsFKvet")]

        public int? Clinic_Id { get; set; }

        public Clinics? Clinics { get; set; }


        public string Vet_Username { get; set; }

        public string Vet_Password { get; set; }    


    }
}
