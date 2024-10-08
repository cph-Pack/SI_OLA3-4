using MyTrailer_Backend.Data;
using MyTrailer_Backend.Models;

namespace MyTrailer_Backend
{
    public class TrailerRentalService
    {
        private DBManager _dbManager;
        private TrailerManager _trailerManager;
        private RentalManager _rentalManager;

        public TrailerRentalService()
        {
            _dbManager = new DBManager();
            _rentalManager = new RentalManager(_dbManager);
            _trailerManager = new TrailerManager(_dbManager);
        }

        public List<Trailer> GetAllTrailers()
        {
            return _trailerManager.GetAllTrailers();
        }

        public Rental RentTrailer(int trailerNumber, RentalRequest request)
        {
            Trailer trailer = _trailerManager.findTrailerByTrailerNumber(trailerNumber);
            Customer customer = new Customer();
            {
                customer.Id = request.CustomerId;
                customer.Name = "John";
                customer.Email = "jd@gmail.com";
            }
            Rental rental = new Rental(trailer, customer, request.StartTime, request.EndTime, request.RentalType, request.HasInsurance);
            return _rentalManager.RentTrailer(rental);
        }
    }
}
