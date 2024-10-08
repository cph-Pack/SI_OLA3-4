using Microsoft.AspNetCore.Mvc;

namespace MyTrailer_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrailerController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }

    }
}
