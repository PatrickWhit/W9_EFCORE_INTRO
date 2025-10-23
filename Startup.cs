using Microsoft.Extensions.DependencyInjection;
using W9_EFCORE_INTRO;

namespace W6_SOLID_DIP;

public static class Startup
{
    public static IServiceCollection ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        // Register services and dependencies
        services.AddTransient<IMainService, MainService>();
        services.AddSingleton<Program>();

        return services;
    }
}