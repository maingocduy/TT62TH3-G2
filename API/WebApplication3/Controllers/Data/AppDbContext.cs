using Microsoft.EntityFrameworkCore;
using WebApplication3.Entities;

namespace WebApplication3.Controllers.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<account> account { set; get; }
        public DbSet<account> member { set; get; }
        public DbSet<account> group { set; get; }
        public DbSet<account> news { set; get; }
        public DbSet<account> project { set; get; }
        public DbSet<sponsor> sponsor { set; get; }
    }
}
