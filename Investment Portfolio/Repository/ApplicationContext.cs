using Investment_Portfolio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Investment_Portfolio.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
