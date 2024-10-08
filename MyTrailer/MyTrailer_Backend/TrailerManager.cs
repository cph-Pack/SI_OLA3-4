using MyTrailer_Backend.Data;

namespace MyTrailer_Backend
{
    public class TrailerManager
    {
        private DBManager _dbManager;

        public TrailerManager(DBManager dbManager)
        {
            _dbManager = dbManager;
        }

        public List<Trailer> GetAllTrailers() 
        { 
            return _dbManager.GetAllTrailers(); 
        }

        public List<Trailer> GetAllAvailableTrailers()
        {
            return new List<Trailer>();
        }

        public List<Trailer> GetAvailableTrailersByLocation(Location location)
        {
            return new List<Trailer>();
        }

        internal Trailer findTrailerByTrailerNumber(int trailerNumber)
        {
            return _dbManager.findTrailerByTrailerNumber(trailerNumber);
        }
    }
}
