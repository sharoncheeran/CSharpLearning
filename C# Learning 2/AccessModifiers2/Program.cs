namespace AccessModifiers2
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            this.CalculateRating(excludeOrders: true);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}
