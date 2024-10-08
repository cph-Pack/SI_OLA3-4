using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MyTrailer_Backend.Data
{
    public class Bill
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public Customer Customer { get; private set; }
        public int TotalAmount { get; private set; } = 0;
        public DateTime BillingDate { get; private set; } = DateTime.Now;

        public Bill(Customer customer) 
        {
            Customer = customer;
        }

        public void AddLateFee(int  amount)
        {
            TotalAmount += amount;
        }

        public void AddInsurance()
        { 
            TotalAmount += 50;
        }
    }
}
