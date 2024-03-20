// See https://aka.ms/new-console-template for more information
// screen Sound 
using System.Linq;

string mensagemInicial ="boas vindas ao Screen sound ";
//List<String> ListaDeBandas = new List<string> {"u2", "Acdc","restart" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("linkin park", new List<int> { 10, 9, 7,5 });
bandasRegistradas.Add("paramore", new List<int> { });

void ExibirOpcoesDeMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar a banda");
    Console.WriteLine("Digite 2 para mostrar as bandas");
    Console.WriteLine("Digite 3 pare exibir a media de uma banda");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("DIgite 5 para sair");
}
void ExibirLogo()
{
    Console.WriteLine(@"
██████████████████████████████████████████████
█▄─▀█▄─▄█─▄▄─█▄─█─▄██▀▄─████▄─▄▄─█▄─▄▄▀██▀▄─██
██─█▄▀─██─██─██▄▀▄███─▀─█████─▄█▀██─▄─▄██─▀─██
▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▀▄▀▀▀▄▄▀▄▄▀▀▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀");
    Console.WriteLine(mensagemInicial);

    Console.WriteLine("\n Digite sua opção: ");

    string opcEscolhida = Console.ReadLine()!;
    int opcEscolhidaNum = int.Parse(opcEscolhida);

    switch (opcEscolhidaNum)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistrada();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            CalculaMedia();
            break;
        case -1:
            Console.WriteLine(" Sempre retorne para mostrar a melhor banda ;} " + opcEscolhidaNum);
            break;
        default:
            Console.WriteLine("Opção invalida, até breve ;[");
            break;
    }


    void RegistrarBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registrar bandas");
        Console.Write(" DIgitie o nome da banda que quer registrar:  ");
        String nomeDaBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Console.WriteLine($"a banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDeMenu();

    }

    void MostrarBandasRegistrada()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Mostrar Bandas Registradas");

        //for (int i = 0; i < ListaDeBandas.Count; i++)
        //{
        //  Console.WriteLine($" banda: {ListaDeBandas[i]}");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($" banda: {banda}");
        }

        Console.WriteLine("\n Digite uma tecla para voltar ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDeMenu();
    };

    void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }


    void AvaliarUmaBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("avaliar uma banda");
        Console.Write("digite o  nome da banda que deseja avaliar:");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write($"Qual nota a banda {nomeDaBanda} merece?");
            int nota = int.Parse(Console.ReadLine()!);
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.WriteLine($"\n A nota {nota} para a banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDeMenu();
           
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não existe");
            Console.WriteLine("pressione uma tecla para voltar ao menu");
            Console.ReadKey();
            ExibirOpcoesDeMenu();
        }
 
    }

    void CalculaMedia()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Calcular Media Da Banda");
        Console.Write("Digite o nome das bandas que deseja calcular a média: ");
        string nomeDaBanda = Console.ReadLine();
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {

            List<int> notasdaBanda = bandasRegistradas[nomeDaBanda];

            Console.WriteLine($"\n mpedia das notas da banda {nomeDaBanda} é {notasdaBanda.Average()} ");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDeMenu();
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não existe");
            Console.WriteLine("pressione uma tecla para voltar ao menu");
            Console.ReadKey();
            ExibirOpcoesDeMenu();
        }
    }

}

ExibirLogo();

ExibirOpcoesDeMenu();