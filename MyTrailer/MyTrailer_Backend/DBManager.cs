using System.Formats.Asn1;
using System.Net.Sockets;
using System.Xml.Linq;
using MongoDB.Driver;
using MyTrailer_Backend.Data;

namespace MyTrailer_Backend
{
    public class DBManager
    {
        private const string connectionUri = "mongodb://localhost:27017";
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;

        private readonly IMongoCollection<Trailer> _trailerColl;
        private readonly IMongoCollection<Rental> _rentalColl;

        public DBManager()
        {
            _client = new MongoClient(connectionUri);
            _database = _client.GetDatabase("SI");

            _trailerColl = _database.GetCollection<Trailer>("trailers");
            _rentalColl = _database.GetCollection<Rental>("rentals");
        }

        public void InsertTrailer(Trailer trailer)
        {
            _trailerColl.InsertOne(trailer);
        }

        public List<Trailer> GetAllTrailers()
        {
            return _trailerColl.Find<Trailer>(_ => true).ToList();
        }

        public void InsertRental(Rental rental)
        {
            _rentalColl.InsertOne(rental);
        }

        public Trailer findTrailerByTrailerNumber(int trailerNumber)
        {
            return _trailerColl.Find<Trailer>(t => t.TrailerNumber == trailerNumber).FirstOrDefault();
        }
    }

}
