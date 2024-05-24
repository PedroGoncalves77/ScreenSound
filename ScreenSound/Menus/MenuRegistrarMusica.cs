using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarMusica : Menu
{
    public override void Executar()
    {
        Context context = new Context();
        var dal = new DAL<Artista>(context);
        base.Executar();
        ExibirTituloDaOpcao("Registro de músicas");
        Console.Write("Digite o artista cuja música deseja registrar: ");
        string nomeDoArtista = Console.ReadLine()!;
        if (context.Artista.Any(x => x.Nome.Equals(nomeDoArtista)))
        {
            Console.Write("Agora digite o título da música: ");
            string tituloDaMusica = Console.ReadLine()!;
            Console.Write("Agora digite o ano da música: ");
            string anoDaMusica = Console.ReadLine()!;
            int.TryParse(anoDaMusica, out var ano);
            Artista artista = dal.RetornaPor(x => x.Nome.Equals(nomeDoArtista))!;
            artista.AdicionarMusica(new Musica(tituloDaMusica) { AnoLancamento = ano});
            Console.WriteLine($"A música {tituloDaMusica} de {nomeDoArtista} foi registrada com sucesso!");
            dal.Alterar(artista);
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO artista {nomeDoArtista} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
