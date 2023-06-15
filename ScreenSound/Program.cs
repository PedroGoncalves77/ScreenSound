using System;


namespace ScreenSound 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Episodio ep2 = new(2, "Nome do ep1", 45);
            ep2.AdicionarConvidado("Convidado0");
            ep2.AdicionarConvidado("Convidado1");
            ep2.AdicionarConvidado("Convidado3");

            Episodio ep3 = new(3, "Nome do ep2", 35);
            ep3.AdicionarConvidado("Convidado0");
            ep3.AdicionarConvidado("Convidado1");
            ep3.AdicionarConvidado("Convidado3");

            Episodio ep1 = new(1, "Nome do ep3", 77);
            ep1.AdicionarConvidado("Convidado0");
            ep1.AdicionarConvidado("Convidado1");
            ep1.AdicionarConvidado("Convidado3");

            Podcast podcast = new("Nome do podcast", "Nome do apresentador");
            podcast.AdicionarEpisodio(ep1);
            podcast.AdicionarEpisodio(ep2);
            podcast.AdicionarEpisodio(ep3);
            podcast.ExibirDetalhesDoPodcast();


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