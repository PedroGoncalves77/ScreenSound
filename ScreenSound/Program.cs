using System;


namespace ScreenSound 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            var Episodio ep1 = new(1, "Nome do ep1", 45);
            ep1.AdicionarConvidado("Convidado0");
            ep1.AdicionarConvidado("Convidado1");
            ep1.AdicionarConvidado("Convidado3");
            var banda1 = new Banda("Nome da banda 1");
            
            var musica1 = new Musica("Nome da musica 1", banda1);
            musica1.DuracaoEmSegundos = 213;
            musica1.Disponivel = false;

            var musica2 = new Musica("Nome da musica 2", banda1);
            musica2.DuracaoEmSegundos = 345;
            musica2.Disponivel = true;

            musica1.ExibirFichaTecnica();
            musica2.ExibirFichaTecnica();
            
            
            var album = new Album("Nome do album");
            album.AdicionarMusica(musica1);
            album.AdicionarMusica(musica2 );

           
            banda1.AdicionarAlbum(album);
            banda1.AdicionarDiscografia();
        }
    }
}