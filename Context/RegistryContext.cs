using Microsoft.EntityFrameworkCore;
using WebApplication35.Models;

namespace WebApplication35.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class RegistryContext:DbContext
    {
        public RegistryContext(DbContextOptions<RegistryContext> options) : base (options)
        {


        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");

        }
    }
}
