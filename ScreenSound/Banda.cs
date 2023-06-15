namespace ScreenSound 
{
    public class Banda 
    {
        public Banda(string nome)
        {
            Nome = nome;
        }
        private List<Album> albums = new List<Album>();
        public string Nome { get;}

        public void AdicionarAlbum(Album album) => albums.Add(album);
        public void AdicionarDiscografia() 
        {
            Console.WriteLine($"Discografia da banda {Nome} \n");
            foreach(Album album in albums) 
            {
                Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
            }

        }
    }
}