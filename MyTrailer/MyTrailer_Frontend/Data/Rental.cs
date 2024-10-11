namespace MyTrailer_Frontend.Data
{
    public class Rental
    {
        public int Id { get; set; }
        public string Trailer { get; set; } // Example property
        public string Customer { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public RentalType RentalType { get; set; }
        public bool HasInsurance { get; set; }
    }
}
