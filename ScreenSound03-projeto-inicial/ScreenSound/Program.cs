
Banda ACDC = new Banda("AC/DC");

Banda Ret = new("Filipe Ret");

Banda Djonga = new("Djonga");
Djonga.AdicionarNota(new Avaliacao(10));
Djonga.AdicionarNota(new Avaliacao(8));
Djonga.AdicionarNota(new Avaliacao(9));

Banda MajorRD = new("Major RD");
MajorRD.AdicionarNota(new Avaliacao(10));
MajorRD.AdicionarNota(new Avaliacao(7));
MajorRD.AdicionarNota(new Avaliacao(9));

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(Djonga.Nome, Djonga);
bandasRegistradas.Add(MajorRD.Nome, MajorRD);
bandasRegistradas.Add(ACDC.Nome, ACDC);
bandasRegistradas.Add(Ret.Nome, Ret);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandasRegistradas ());
opcoes.Add(4, new MenuAvaliarBanda ());
opcoes.Add(5, new MenuAvaliarAlbum ());
opcoes.Add(6, new MenuExibirDetalhes ());
opcoes.Add(-1, new MenuSair());




void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine("Opção inválida");
    }
}


ExibirOpcoesDoMenu();