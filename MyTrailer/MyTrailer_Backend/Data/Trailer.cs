using System.Runtime.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyTrailer_Backend.Data
{
    public class Trailer
    {
        [BsonId]
        public ObjectId Id {  get; set; } 
        public int LocationId { get; set; }
        public int TrailerNumber { get; set; }
    }
}
