using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class PlatformContext : DbContext
    {
        public PlatformContext(DbContextOptions<PlatformContext> options) : base(options)
        {
        }

        public DbSet<Announce> Announces { get; set; }
        public DbSet<AnnounceType> AnnounceTypes { get; set; }
    }
}
