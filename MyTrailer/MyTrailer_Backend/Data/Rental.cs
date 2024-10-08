using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MyTrailer_Backend.Data
{
    public class Rental
    {
        [BsonId]
        public ObjectId Id { get; private set; }
        public Trailer Trailer { get; private set; }
        public Customer Customer { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public RentalType RentalType { get; private set; }
        public bool HasInsurance { get; private set; }

        public Rental(Trailer trailer, Customer customer, DateTime startTime, DateTime endTime, RentalType rentalType, bool hasInsurance)
        {
            if (rentalType == RentalType.ShortTerm && IsLaterThanMidnight(endTime))
                throw new InvalidOperationException("Short term rental must end by midnight.");

            Trailer = trailer;
            Trailer.RentTrailer(endTime);
            Customer = customer;
            StartTime = startTime;
            EndTime = endTime;
            RentalType = rentalType;
            HasInsurance = hasInsurance;
        }
        private static bool IsLaterThanMidnight(DateTime endTime)
        {
            return endTime > DateTime.Today.AddDays(1); //midnight
        }
    }
}
