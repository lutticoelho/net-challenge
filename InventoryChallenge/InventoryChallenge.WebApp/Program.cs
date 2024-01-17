using InventoryChallenge.IoC;

namespace InventoryChallenge.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRepository();

            builder.Services.AddTwillioEmailService();
            //builder.Services.AddSendGridEmailService(); // Is possible to change the thirdy party application used to send e-mails by changing Dependency Injection used in the startup of the project.

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}