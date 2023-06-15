using System;
namespace ScreenSound
{
	public class Musica
	{
        public Musica(string nome, Banda artista)
        {
			Nome = nome;
			Artista = artista;
        }

        public string Nome { get;}
		public Banda Artista { get;}
		public int DuracaoEmSegundos { get; set; }
		public bool Disponivel { get; set; }
		public string NomeCompleto { get; set; }

		



	 public void ExibirFichaTecnica()
		{
			Console.WriteLine($"Nome: {Nome}");
			Console.WriteLine($"Artista: {Artista.Nome}");
			Console.WriteLine($"Duracao: {DuracaoEmSegundos}");
			if (Disponivel)
				Console.WriteLine("Musica disponivel");
			else
				Console.WriteLine("Atualize seu plano");

		}

	}
}
