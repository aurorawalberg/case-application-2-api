namespace TheMovingCompanyAPI.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ServiceType { get; set; }
        public DateTime Date { get; set; }
    }
}
