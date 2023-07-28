using Food.Data.Models;
using System.Data.Entity;

namespace Food.Data.Services
{
    public class FoodDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
