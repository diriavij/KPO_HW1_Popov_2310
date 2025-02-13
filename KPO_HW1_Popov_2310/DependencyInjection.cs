using Microsoft.Extensions.DependencyInjection;

namespace KPO_HW1_Popov_2310;

public class DependencyInjection
{
    public static void Configure(IServiceCollection services)
    {
        services.AddSingleton<VetClinic>();
        services.AddSingleton<Zoo>();
    }
}