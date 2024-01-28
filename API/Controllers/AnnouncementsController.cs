using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnnouncementsController : ControllerBase
    {
        [HttpGet]
        public string GetAnnouncements()
        {
            return "this will be a list of announcements";
        }

        [HttpGet("{id}")]
        public string GetAnnounce(int id)
        {
            return "singe announce";
        }
    }
}
