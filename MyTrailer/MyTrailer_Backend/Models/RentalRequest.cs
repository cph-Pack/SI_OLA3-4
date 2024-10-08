using MyTrailer_Backend.Data;

namespace MyTrailer_Backend.Models
{
    public class RentalRequest
    {
        public int CustomerId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public RentalType RentalType { get; set; }
        public bool HasInsurance { get; set; }
    }
}
