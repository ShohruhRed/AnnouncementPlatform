using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AnnounceRepository : IAnnounceRepository
    {
        private readonly PlatformContext _context;

        public AnnounceRepository(PlatformContext context)
        {
            _context = context;
        }
        public async Task<Announce> GetAnnounceByIdAsync(int id)
        {
            return await _context.Announces.FindAsync(id);
        }

        public async Task<IReadOnlyList<Announce>> GetAnnouncesAsync()
        {
            return await _context.Announces.ToListAsync();
        }
    }
}
