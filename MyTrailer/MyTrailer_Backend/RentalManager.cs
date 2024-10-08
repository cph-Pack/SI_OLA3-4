using MyTrailer_Backend.Data;

namespace MyTrailer_Backend
{
    public class RentalManager
    {
        private DBManager _dbManager;
        private readonly int LateFee = 100;

        public RentalManager(DBManager dbManager)
        {
            _dbManager = dbManager;
        }

        public Rental RentTrailer(Rental rental) 
        {
            _dbManager.InsertRental(rental);
            return rental;
        }

        public Bill ReturnTrailer(Rental rental) 
        { 
            Bill bill = new Bill(rental.Customer);
            if (rental.HasInsurance)
            {
                bill.AddInsurance();
            }

            if (rental.Trailer.IsLateReturn())
            {
                bill.AddLateFee(LateFee);
            }

            rental.Trailer.ReturnTrailer();
            return bill; 
        }
    }
}
