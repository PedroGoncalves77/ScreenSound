using System.Reflection;

namespace ScreenSound
{
    public class Album
    {
        public Album(string nome)
        {
            Nome = nome;

        }

        private List<Musica> musicas = new List<Musica>();
        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(m => m.DuracaoEmSegundos);

        public void AdicionarMusica(Musica musica) => musicas.Add(musica);

        public void ExibirMusicasDoAlbum() 
        {
            
            Console.WriteLine($"As musicas do Album {Nome} são:\n");
            foreach(var musica in musicas) 
            {
                Console.WriteLine(musica.Nome);
            }
        }
        public void ExibirDuracaoDoAlbum() => Console.WriteLine($"O tempo total de todas as musicas do album é : {DuracaoTotal}");



    }
}