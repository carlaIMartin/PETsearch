using System.ComponentModel.DataAnnotations;

namespace PETSearch.Models
{
    public class Locations
    {
         public int Location_Id { get; set; }
        [Key] public string Location { get; set; }
       

    }
}
