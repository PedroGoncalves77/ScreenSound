using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarArtistas : Menu
{
    public override void Executar()
    {
        base.Executar();
        using Context context = new Context();
        var artistaDAL = new DAL<Artista>(context);
        var artistas = artistaDAL.Listar();
        ExibirTituloDaOpcao("Exibindo todos os artistas registradas na nossa aplicação");
        foreach (var a in artistas)
        {
            Console.WriteLine(a);
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
