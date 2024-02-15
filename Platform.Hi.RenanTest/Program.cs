using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Platform.Hi.RenanTest.SegundaQuestao;
using Platform.Hi.RenanTest.SegundaQuestao.Services;
using Platform.Hi.RenanTest.TerceiraQuestao;
using Platform.Hi.RenanTest.TerceiraQuestao.Models;
using Platform.Hi.RenanTest.TerceiraQuestao.Services;
using System.Globalization;

IHost host = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddSegundaQuestaoApplication();
    services.AddTerceiraQuestaoApplication();
}).Build();

Console.WriteLine("1. ");
Console.WriteLine(@"A: Depende o seu objetivo a ser alcançado, casos com interfaces você usa para garante que a classe que esta implementando, tenha a implementação de métodos e propriedades, assim garantindo
que, quando utilizado/chamado para alguma requisição, tenha suas funcionalidades desenvolvidas. Ao adicionar injeção de bibliotecas, você pode compartilhar apenas a bibliteca que contém o contrato das requisições
sem mesmo compartilhar a sua implementação. Para classes abstratas você também pode exigir a implementação de métodos e propriedades, podendo criar uma base destes métodos ja desenvolvida, podendo ou não ser sobrescrita
ou sendo utilizada para base de método.");
Console.WriteLine(@"B: Casos de herança são utilizado para reaproveitar dados e métodos, quando uma classe A herda de outra class B, tem o significado que a classe A contém os mesmos dados e espeficicações/caracteristicas
que a classe B. Como por exemplo, a classe B seria uma classe para especificar as caracteristicas de Fruta, e a classe A seria especificação de uma Banana. Para delegação, dado o uso quando quando você quer especificar
uma caracteristica que uma classe tem, um método/função em comum entre elas, mas não todas as caracteristicas. Diferença entre, banana é uma fruta, e banana tem função de descascar.");

Console.WriteLine(" ");
Console.WriteLine("=================================================");
Console.WriteLine(" ");

Console.WriteLine("2. Resultado. Usado constantes para definir alguns dados para base de calculo.");
var calculadoraService = host.Services.GetRequiredService<ICalculadoraService>();
var segundoResultado = calculadoraService.PrecoCobrar(new Platform.Hi.RenanTest.SegundaQuestao.Dtos.ItemDto()
{
    CustoAquisicao = 100,
    ValidadeEmDias = 15,
    VolumeOcupado = 100,
    PrecisaRefrigeracao = true,
    Fabricacao = DateTime.Now
});
Console.WriteLine(segundoResultado.ToString("C2", new CultureInfo("pt-BR")));

Console.WriteLine(" ");
Console.WriteLine("=================================================");
Console.WriteLine(" ");

Console.WriteLine("3. Resultado");
Rua ruaA = new Rua { Cep = "12312-123", Nome = "Rua A" };
Rua ruaB = new Rua { Cep = "45645-456", Nome = "Rua B" };
Rua ruaC = new Rua { Cep = "78978-789", Nome = "Rua C" };

List<Casa> listaCasas = new List<Casa>
{
    new Casa { Rua = ruaA, Numero = 1, TotalEleitores = 123 },
    new Casa { Rua = ruaB, Numero = 2, TotalEleitores = 456 },
    new Casa { Rua = ruaC, Numero = 3, TotalEleitores = 143 }
};

var eleicaoService = host.Services.GetRequiredService<IEleicaoService>();
var terceiroResultado = eleicaoService.GetMelhoresRuas(listaCasas);
terceiroResultado.ForEach(x =>
{
    Console.WriteLine(x.ToString());
});

Console.WriteLine(" ");
Console.WriteLine("=================================================");
Console.WriteLine(" ");