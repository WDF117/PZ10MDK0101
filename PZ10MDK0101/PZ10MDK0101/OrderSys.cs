using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace PZ10MDK0101
{
    public class OrderSys : DbContext
    {
        public OrderSys() => Database.EnsureCreated();
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=(localdb)\\local");
        }
    }
}
