using Microsoft.AspNetCore.Mvc;
using MyTrailer_Backend.Data;
using MyTrailer_Backend.Models;

namespace MyTrailer_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrailerController : ControllerBase
    {
        private readonly TrailerRentalService _service = new TrailerRentalService();

        [HttpGet]
        public ActionResult<List<Trailer>> Get()
        {
            List<Trailer> trailers = _service.GetAllTrailers();
            return Ok(trailers);
        }

        [HttpPost("rent/{trailerNumber}")]
        public ActionResult<Rental> RentTrailer(int trailerNumber, [FromBody] RentalRequest request)
        {
            try
            {
                Rental rental = _service.RentTrailer(trailerNumber, request);
                return Ok(rental);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
