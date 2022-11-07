namespace TheMovingCompanyAPI.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ServiceType { get; set; } = null!;
        public DateTime Date { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
    }
}
