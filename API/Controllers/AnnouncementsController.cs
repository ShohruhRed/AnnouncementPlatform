using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnnouncementsController : ControllerBase
    {
        private readonly IAnnounceRepository _repo;

        public AnnouncementsController(IAnnounceRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<ActionResult<List<Announce>>> GetAnnouncements()
        {
            var announce = await _repo.GetAnnouncesAsync();

            return Ok(announce);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Announce>> GetAnnounce(int id)
        {
            return await _repo.GetAnnounceByIdAsync(id);
        }
    }
}
