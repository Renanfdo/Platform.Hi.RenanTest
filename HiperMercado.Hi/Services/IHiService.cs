namespace HiperMercado.Hi.Services;

/// <summary>
/// Integração com Hipermercado, exemplo
/// </summary>
public interface IHiService
{
    double FormulaMagica(double custo,int validade);
}

internal class HiService : IHiService
{
    public double FormulaMagica(double custo, int validade)
    {
        return custo + (custo * 0.3d);
    }
}