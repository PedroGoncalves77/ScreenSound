using ScreenSound.Menus;
using System;
using ScreenSound.Modelos;
Banda ira = new("Ira!");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));

Banda beatles = new("Beatles");
beatles.AdicionarNota(new Avaliacao(10));
beatles.AdicionarNota(new Avaliacao(10));
beatles.AdicionarNota(new Avaliacao (7));

Dictionary<string,Banda >bandasRegistradas = new ();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);
Menu menu = new();
Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new RegistrarBanda());
opcoes.Add(2, new RegistrarAlbum());
opcoes.Add(3, new MostarBandasRegistradas());
opcoes.Add(4, new MenuAaliarBanda());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhe());
opcoes.Add(-1, new Sair());

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
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um album");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    if (int.TryParse(opcaoEscolhida, out int opcaoEscolhidaNumerica))
    {

        if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
        {
            Menu menuDeExibicao = opcoes[opcaoEscolhidaNumerica];
            menuDeExibicao.Executar(bandasRegistradas);
            if (opcaoEscolhidaNumerica > 0) {ExibirOpcoesDoMenu(); }
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
    }
    else { Console.WriteLine("Opção invalida!");
        ExibirOpcoesDoMenu();
    }

    //switch (opcaoEscolhidaNumerica)
    //{
    //    case 1:
    //        RegistrarBanda registrarBanda = new();
    //        registrarBanda.Executar(bandasRegistradas);
    //        ExibirOpcoesDoMenu();
    //        break;
    //    case 2:
    //        RegistrarAlbum registrarAlbum = new();
    //        registrarAlbum.Executar(bandasRegistradas);
    //        ExibirOpcoesDoMenu();
    //        break;
    //    case 3:
    //        MostarBandasRegistradas mostarBandas = new();
    //        mostarBandas.Executar(bandasRegistradas);
    //        ExibirOpcoesDoMenu();
    //        break;
    //    case 4:
    //        MenuAaliarBanda menuAaliarBanda = new();
    //        menuAaliarBanda.Executar(bandasRegistradas);
    //        ExibirOpcoesDoMenu();
    //        break;
    //    case 5:
    //        MenuExibirDetalhe exibirDetalhes = new();
    //        exibirDetalhes.Executar(bandasRegistradas);
    //        ExibirOpcoesDoMenu();           
    //        break;
    //    case -1:
    //        Sair.Executar();            
    //        break;
    //    default:
    //        Console.WriteLine();
    //        break;
    //}
}
ExibirOpcoesDoMenu();



