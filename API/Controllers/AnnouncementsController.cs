using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnnouncementsController : ControllerBase
    {
        private readonly PlatformContext _context;

        public AnnouncementsController(PlatformContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Announce>>> GetAnnouncements()
        {
            return await _context.Announces.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Announce>> GetAnnounce(int id)
        {
            return await _context.Announces.FindAsync(id);
        }
    }
}
