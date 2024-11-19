namespace CW_13.Entityes
{
    public class Territory
    {
        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public List<EmployeeTerritory> EmployeeTerritories { get; set; }
    }
}
