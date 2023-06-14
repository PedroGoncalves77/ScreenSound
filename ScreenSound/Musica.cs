using System;
namespace ScreenSound
{
	public class Musica
	{
        public Musica(Banda artista)
        {
			Artista = artista;
        }

        public string Nome { get; set; }
		public string Artista { get; set; }
		public int DuracaoEmSegundos { get; set; }
		public bool Disponivel { get; set; }
		public string NomeCompleto { get; set; }

		



	 public void ExibirFichaTecnica()
		{
			Console.WriteLine($"Nome: {Nome}");
			Console.WriteLine($"Artista: {Artista}");
			Console.WriteLine($"Duracao: {DuracaoEmSegundos}");
			if (Disponivel)
				Console.WriteLine("Musica disponivel");
			else
				Console.WriteLine("Atualize seu plano");

		}

	}
}
