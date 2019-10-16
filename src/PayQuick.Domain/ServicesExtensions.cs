using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayQuick.Domain.Abstractions;
using PayQuick.Domain.Settings;

namespace PayQuick.Domain
{
    public static class ServicesExtensions
    {
        public static IServiceCollection RegisterDomain(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .Configure<PayQuickSettings>(configuration.GetSection("PayQuickSettings")).AddTransient<IPayQuickService, PayQuickService>();
        }
    }
}