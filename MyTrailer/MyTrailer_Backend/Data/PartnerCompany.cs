using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MyTrailer_Backend.Data
{
    public class PartnerCompany
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }

    }
}
