using Microsoft.EntityFrameworkCore;
using agay.Models;

namespace agay.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
        base(options)
        {
            
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Instrument> Instruments { get; set; }

    }
}