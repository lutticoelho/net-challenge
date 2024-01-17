using EmailService.Sendgrid;
using EmailService.Twillio;
using InventoryChallenge.EmailProvider.Contract;
using InventoryChallenge.Repository;
using InventoryChallenge.Repository.Contract;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryChallenge.IoC
{
    public static class Modules
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }

        public static IServiceCollection AddTwillioEmailService(this IServiceCollection services)
        {
            services.AddScoped<ISendEmail, SendEmail>();
            return services;
        }

        public static IServiceCollection AddSendGridEmailService(this IServiceCollection services)
        {
            services.AddScoped<ISendEmail, Email>();
            return services;
        }
    }
}