using Microsoft.EntityFrameworkCore;

namespace corePizzaProject.Models
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User1> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HSC-PF25NJE3;Database=PizzaDB;Integrated Security=true;TrustServerCertificate=true");
        }
    }
}
