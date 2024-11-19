namespace CW_13.Entityes
{
    public class EmployeeTerritory
    {
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }
        public Territory Territory { get; set; }
        public Employee Employee { get; set; }
    }
}
