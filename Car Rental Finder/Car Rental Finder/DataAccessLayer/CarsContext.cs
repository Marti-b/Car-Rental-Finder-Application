using Car_Rental_Finder.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Rental_Finder.DataAccessLayer
{
    public class CarsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Car> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=CarRentalDb;");
        }
    }
}
