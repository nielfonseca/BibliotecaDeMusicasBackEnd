//Screen Sound
string mensagemDeBoasVindas = "Boas Vindas ao Biblio Music!";
//List<string> listaDasBandas = new List<string> {"Artic Monkeys", "Imagine Dragons", "Black Eyes Peas" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Arctic Monkeys", new List<int> {10, 9, 8});
bandasRegistradas.Add("Imagine Dragons", new List<int>());

void ExibirMensagemDeBoasVindas()
{
    ExibirTituloDaOpcao(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Selecione uma opção:");
    Console.WriteLine("1 - Registrar uma Banda");
    Console.WriteLine("2 - Mostrar todas a bandas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir a média de uma banda");
    Console.WriteLine("0 - Sair");

    Console.Write("\nDigite sua Opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1:RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            MediaDaBanda();
            break;
        case 0:
            Console.WriteLine("Saindo do programa. Até logo!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, tente novamente.");
            break;
    }

}

// Função para Registrar uma banda nova
// Aprendido: Criar uma lista para adicionar as bandas no dicionário
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registrar uma banda");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda '{nomeDaBanda}' foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

// Função para Mostrar todas as Bandas Registradas
// Aprendido: Percorrer as chaves do dicionário utilizando o .Keys e percorrer o dicionário com foreach 
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco + "\n");
}

void AvaliarUmaBanda()
{


    // Aprendido: Utilizar o .Add para adicionar um valor a uma determinada chave do dicionário
    // Aprendido: Verificar se existe a chave no dicionário utilizando o nome dela com o .ContainsKey

    /* O [ ] Serve para indexar o dicionário e acessar as chaves, podendo ir direto para o valor,
     * utilizando o .Add para atribuir um valor para aquela determinada chave */

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar uma banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota você deseja dar para a banda {nomeDaBanda}? Digite: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi adicionada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda '{nomeDaBanda}' não está registrada. Por favor, registre a banda antes de avaliá-la.");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MediaDaBanda()
{
    Console.Clear();
    Console.Write("Qual o nome da banda que deseja ver a média?: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda '{nomeDaBanda}' não está registrada. Por favor, registre a banda antes de avaliá-la.");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}


ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();