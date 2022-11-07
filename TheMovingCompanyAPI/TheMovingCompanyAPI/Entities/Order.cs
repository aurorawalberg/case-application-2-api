namespace TheMovingCompanyAPI.Entities
{
    public class Order
    {

        public Order()
        {
            Services = new HashSet<Service>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string FromAdress { get; set; } = null!;
        public string ToAdress { get; set; } = null!;
        public string? Note { get; set; }
        public DateTime Date { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<Service> Services { get; set; }
    }
}
