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
Console.WriteLine("A: Depende o seu objetivo a ser alcançado, casos com interfaces você usa para garante que a classe que esta implementando, tenha a implementação de métodos e propriedades, assim garantindo que, "
    +"quando utilizado/chamado para alguma requisição, tenha suas funcionalidades desenvolvidas. Ao adicionar injeção de bibliotecas, você pode compartilhar apenas a bibliteca que contém o contrato das requisições "
    +"sem mesmo compartilhar a sua implementação. Para classes abstratas você também pode exigir a implementação de métodos e propriedades, podendo criar uma base destes métodos ja desenvolvida, podendo ou não ser "
    +"sobrescrita ou sendo utilizada para base de método.");
Console.WriteLine(@"B: Casos de herança são utilizado para reaproveitar dados e métodos, quando uma classe A herda de outra class B, tem o significado que a classe A contém os mesmos dados e espeficicações/"
    +"caracteristicas que a classe B. Como por exemplo, a classe B seria uma classe para especificar as caracteristicas de Fruta, e a classe A seria especificação de uma Banana. Para delegação, dado o uso "
    +"quando quando você quer especificar uma caracteristica que uma classe tem, um método/função em comum entre elas, mas não todas as caracteristicas. Diferença entre, banana é uma fruta, e banana tem função "
    +"de descascar.");

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

Console.WriteLine("4. ");
Console.WriteLine(@"A: Sim, para todos os casos que você queira interpretar/especificar o erro que está acontecendo, assim a origem da requisição pode tratar diferentes tipos de erros de acordo com a Exception recebida.");
Console.WriteLine(@"B: Quando você quer corrigir ou tratar o erro que você espera, para que o usuário tenha uma boa experiencia com o sistema sem transparecer erros sistemáticos. Como exemplo exceções de "
    +"infraestrutura/integrações, quando realizado uma integração onde o sistema destino não responde, deveria existir um tratativa de contorno para este erro.");
Console.WriteLine(@"C: Lançada exceção quando o método ou código esta recebendo dados que não são coerentes ou não esperados, evitando que tenha erros na execução. Além da tratativa de entrada de dados, teremos "
    +"exceção para regras de negócio, para funcionalidade que não devem seguir em frente por alguma regra de negócio. Assim que não retornar exceção, o código/método terá sua execução completa com sucesso.");

Console.WriteLine(" ");
Console.WriteLine("=================================================");
Console.WriteLine(" ");

Console.WriteLine("5. ");
Console.WriteLine(@"Depende de cada situação e como esta sendo utilizado este web service, se as interfaces estão com injeção de Singleton, Transient ou Scoped. Para o EntityFrameWork você pode estar utilizando o "
    +"Tracking para bloqueio de registro, assim ficando bloqueado para sua sessão, assim que realizar o commit/saveChanges, o mesmo é liberado para outras sessões utilizar o registro. Em casos que não há tratativa, é "
    +"comum acontecer erro informando que o registro atual ou alterado por outro na requisição. Também nestes está faltando validação se a conta é existente ou não.");