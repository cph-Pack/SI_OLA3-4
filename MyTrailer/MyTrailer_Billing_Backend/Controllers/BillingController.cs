using Microsoft.AspNetCore.Mvc;
using MyTrailer_Billing_Backend.Data;

namespace MyTrailer_Billing_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillingController : ControllerBase
    {
        DBManager _dbManager = new DBManager();
       
        [HttpPost]
        public void addBill([FromBody] Bill bill)
        {
            _dbManager.insertBill(bill);
        }

        [HttpGet]
        public ActionResult<Rental> getBill(String email)
        {
            Rental rental = _dbManager.GetRental(email);
            return Ok(rental);
        }


    }
}
