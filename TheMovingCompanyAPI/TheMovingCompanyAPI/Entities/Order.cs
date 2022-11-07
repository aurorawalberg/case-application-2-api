namespace TheMovingCompanyAPI.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string FromAdress { get; set; }
        public string ToAdress { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
    }
}
