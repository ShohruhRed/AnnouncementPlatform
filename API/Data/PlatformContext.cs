using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class PlatformContext : DbContext
    {
        public PlatformContext(DbContextOptions<PlatformContext> options) : base(options)
        {
        }

        public  DbSet<Announce> Announces { get; set; }
    }
}
