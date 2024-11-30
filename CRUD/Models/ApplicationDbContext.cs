using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        
        }

        public DbSet<Customer> Customers{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "Vvs", LastName = "s", Email = "xyz@gmail.com" },
                new Customer { Id = 2, FirstName = "V", LastName = "V", Email = "yz@gmail.com" },
                new Customer { Id = 3, FirstName = "S", LastName = "T", Email = "xz@gmail.com" }



                );
        }
    }
}
