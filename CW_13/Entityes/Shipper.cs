namespace CW_13.Entityes
{
    public class Shipper
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string? Phone { get; set; }
        public List<Order> Orders { get; set; }
    }
}
