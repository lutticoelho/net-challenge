namespace InventoryChallenge.Model
{
    public class AnnualReport
    {
        public int Id { get; set; }
        public int YearOfReference { get; set; }
        public int Status { get; set; } // Could be an enum
    }
}
