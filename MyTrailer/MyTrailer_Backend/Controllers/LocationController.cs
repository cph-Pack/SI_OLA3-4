using Microsoft.AspNetCore.Mvc;
using MyTrailer_Backend.Data;

namespace MyTrailer_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Location> Get()
        {
            Location location = new Location();
            {
                location.LocationId = 1000;
                location.LocationName = "Copenhagen";
            }
            return Ok(location);
        }
    }
}
