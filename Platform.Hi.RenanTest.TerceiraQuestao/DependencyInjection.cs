using Microsoft.Extensions.DependencyInjection;
using Platform.Hi.RenanTest.TerceiraQuestao.Services;

namespace Platform.Hi.RenanTest.TerceiraQuestao;
public static class DependencyInjection
{
    public static IServiceCollection AddTerceiraQuestaoApplication(this IServiceCollection services)
    {
        services.AddTransient<IEleicaoService, EleicaoService>();

        return services;
    }

}