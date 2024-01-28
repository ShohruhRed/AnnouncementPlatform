using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AnnounceRepository : IAnnounceRepository
    {
        public Task<Announce> GetAnnounceById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Announce>> GetAnnouncesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
