using HiperMercado.Hi.Application;
using Microsoft.Extensions.DependencyInjection;
using Platform.Hi.RenanTest.SegundaQuestao.Services;

namespace Platform.Hi.RenanTest.SegundaQuestao;

public static class DependencyInjection
{
    public static IServiceCollection AddSegundaQuestaoApplication(this IServiceCollection services)
    {
        services.AddHiApplication();

        services.AddTransient<ICalculadoraService, CalculadoraService>();

        return services;
    }
}
