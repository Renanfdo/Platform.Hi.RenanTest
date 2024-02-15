using HiperMercado.Hi.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HiperMercado.Hi.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddHiApplication(this IServiceCollection services)
    {
        services.AddTransient<IHiService, HiService>();

        return services;
    }
}
