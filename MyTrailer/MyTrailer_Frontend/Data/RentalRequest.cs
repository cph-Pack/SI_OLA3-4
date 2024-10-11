namespace MyTrailer_Frontend.Data
{
    public class RentalRequest
    {
        public int CustomerId { get; set; }        // Kunde-ID for at identificere kunden
        public int TrailerNumber { get; set; }     // Trailernummer (identifikation af specifik trailer)
        public DateTime StartTime { get; set; }    // Starttidspunkt for leje
        public DateTime EndTime { get; set; }      // Sluttidspunkt for leje
        public RentalType RentalType { get; set; } // Type af leje (ShortTerm eller LongTerm)
        public bool HasInsurance { get; set; }     // Indikerer om kunden har valgt forsikring
    }
}
