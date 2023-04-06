using System.ComponentModel.DataAnnotations;

namespace PETSearch.Models
{
    public class Locations
    {
        [Key] public int Location_Id { get; set; }
         public string Location { get; set; }
       

    }
}
