using Platform.Hi.RenanTest.TerceiraQuestao.Models;

namespace Platform.Hi.RenanTest.TerceiraQuestao.Services;

public interface IEleicaoService
{
    List<Rua> GetMelhoresRuas(List<Casa> casas);
}


internal class EleicaoService : IEleicaoService
{
    public List<Rua> GetMelhoresRuas(List<Casa> casas)
    {
        var casasOrdenadas = casas.GroupBy(x => new { x.Rua }).Select(x => new { x.First().Rua, TotalEleitores = x.Sum(y => y.TotalEleitores) }).OrderByDescending(x => x.TotalEleitores);
        var ruas = casasOrdenadas.Select(x => x.Rua).ToList();
        return ruas;
    }
}