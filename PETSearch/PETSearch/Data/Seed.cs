using Microsoft.AspNetCore.Identity;
using PETSearch.Data;
using PETSearch.Models;

namespace PETSearch.Data
{
    // *** AICI POPULAM TABELE ***
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Person.Any())
                {
                    context.Person.AddRange(new List<Person>()
                    {
                        new Person()
                        {
                            Person_Id = 1,
                            Person_Name= "Carla Martin",
                            Person_Email= "martincarla05@gmail.com",
                            Location= "Ocna Mures",
                            Person_Username=  "carla3902",
                            Person_Password= "parolacarla",
                            Animal_Id= 1,
                            Person_Phone_Number="0758282693"


                         }

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
