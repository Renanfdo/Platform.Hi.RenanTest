using HiperMercado.Hi.Services;
using Platform.Hi.RenanTest.SegundaQuestao.Consts;
using Platform.Hi.RenanTest.SegundaQuestao.Dtos;

namespace Platform.Hi.RenanTest.SegundaQuestao.Services;

public interface ICalculadoraService
{
    double PrecoCobrar(ItemDto item);
}

internal class CalculadoraService : ICalculadoraService
{
    private readonly IHiService _hiService;

    public CalculadoraService(IHiService hiService)
    {
        _hiService = hiService;
    }

    public double PrecoCobrar(ItemDto item)
    {
        double preco = _hiService.FormulaMagica(item.CustoAquisicao, item.ValidadeEmDias);

        if (item.PrecisaRefrigeracao)
        {
            preco += (preco * (CalculadoraConsts.AcrescimoRefrigeracao / 100));
            }

        if (item.RiscoValidade)
        {
            preco -= (preco * (CalculadoraConsts.DescontoPorValidadeProxima / 100));
            }
        return preco;
    }
}
