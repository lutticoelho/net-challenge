using InventoryChallenge.Model;

namespace InventoryChallenge.Repository.Contract
{
    public interface IAnnualReportRepository
    {
        public AnnualReport GetAnnualReport(int yearOfReference);
    }
}
