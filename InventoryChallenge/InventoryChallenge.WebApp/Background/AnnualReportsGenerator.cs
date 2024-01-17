using InventoryChallenge.Model;
using InventoryChallenge.Repository.Contract;

namespace InventoryChallenge.WebApp.Background
{
    public class AnnualReportsGenerator : BackgroundService
    {

        private readonly ILogger _logger;
        private readonly IServiceProvider _services;

        public AnnualReportsGenerator(ILogger logger, IServiceProvider services)
        {
            _logger = logger;
            _services = services;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // Could be used a CRON expression to do the same job.
                var currentDate = DateTime.UtcNow;
                var targetDate = new DateTime(currentDate.Year, 1, 1);

                if (currentDate >= targetDate)
                {
                    // Check if annaul report is in process or finished
                    var currentReport = await GetAnnualReportAsync(currentDate.Year - 1);
                    if ( currentReport?.Status == 0) 
                    { 
                        // if not start process
                        await StartAnnualReportGenerator();
                    }
                }

                var delay = currentDate - targetDate;

                await Task.Delay(delay);
            }
        }

        private async Task StartAnnualReportGenerator()
        {
            throw new NotImplementedException();
        }

        private async Task<AnnualReport> GetAnnualReportAsync(int year)
        {
            AnnualReport result = null;

            using (var scope = _services.CreateScope())
            {
                var annualReportRepository = scope.ServiceProvider.GetRequiredService<IAnnualReportRepository>();
                result = annualReportRepository.GetAnnualReport(year);
            }

            return result;
        }
    }
}
