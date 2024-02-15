using Platform.Hi.RenanTest.SegundaQuestao.Consts;

namespace Platform.Hi.RenanTest.SegundaQuestao.Dtos;

public sealed class ItemDto
{
    public double CustoAquisicao { get; set; }
    public int ValidadeEmDias { get; set; }
    public int VolumeOcupado { get; set; }
    public bool PrecisaRefrigeracao { get; set; }
    public DateTime Fabricacao { get; set; }
    public DateTime Validade => Fabricacao.AddDays(ValidadeEmDias);
    public bool RiscoValidade => (CalculadoraConsts.QuantidadeDiasAlerta >= (Validade - DateTime.UtcNow).Days);
}
