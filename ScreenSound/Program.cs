using System;
namespace ScreenSound 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            var banda1 = new Banda();
            banda1.Nome = "Nome da banda 1";

            var musica1 = new Musica(banda1);
            musica1.Nome = "Nome da musica 1";
            musica1.DuracaoEmSegundos = 213;

            var musica2 = new Musica(banda1);
            musica2.Nome = "Nome da musica 2";
            musica2.DuracaoEmSegundos = 345;

            var album = new Album();
            album.Nome = "Nome do album";
            album.AdicionarMusica(musica1);
            album.AdicionarMusica(musica2 );

           
            banda1.AdicionarAlbum(album);
            banda1.AdicionarDiscografia();
        }
    }
}