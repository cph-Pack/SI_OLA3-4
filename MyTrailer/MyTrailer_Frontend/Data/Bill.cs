namespace MyTrailer_Frontend.Data
{
    public class Bill
    {
        public string CustomerName { get; set; }
        public int TotalAmount { get; set; } = 0;
        public DateTime BillingDate { get; set; } = DateTime.Now;

        public void AddLateFee(int amount)
        {
            TotalAmount += amount;
        }

        public void AddInsurance(int amount)
        {
            TotalAmount += amount;
        }
    }
}
