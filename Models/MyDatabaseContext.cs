using System.Data.Entity;

namespace Breeze1411_IE8_Bug.Models
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext() : base("MyDatabase")
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}