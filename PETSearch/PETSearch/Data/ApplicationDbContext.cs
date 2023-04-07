using Microsoft.EntityFrameworkCore;
using PETSearch.Models;

namespace PETSearch.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
            
        }

        public DbSet<Animals> Animals { get; set; }
        public DbSet<Clinics> Clinics { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Vets> Vets{ get; set; }
        public DbSet<Persons> Persons { get; set; }

    }
}
