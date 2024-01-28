using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAnnounceRepository
    {
        Task<Announce> GetAnnounceByIdAsync(int id);
        Task<IReadOnlyList<Announce>> GetAnnouncesAsync();
    }
}
