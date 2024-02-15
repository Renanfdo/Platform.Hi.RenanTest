namespace Platform.Hi.RenanTest.TerceiraQuestao.Models;

public sealed class Rua
{
    public string Cep { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;

    public override string? ToString()
    {
        return $"Cep: {Cep}, Nome: {Nome}";
    }
}
