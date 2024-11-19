namespace CW_13.Entityes
{
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
        public List<Territory> Territories { get; set; }
    }
}
