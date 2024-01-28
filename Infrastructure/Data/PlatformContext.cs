using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Data
{
    public class PlatformContext : DbContext
    {
        public PlatformContext(DbContextOptions<PlatformContext> options) : base(options)
        {
        }

        public DbSet<Announce> Announces { get; set; }
        public DbSet<AnnounceType> AnnounceTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
