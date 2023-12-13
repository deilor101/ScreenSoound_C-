using ScreenSound_4;
using ScreenSound_4.Filtros;
using ScreenSound_4.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
	try
	{
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
		var musicas = JsonSerializer.Deserialize<List<Musica>>(response);
		LinqFilter.FiltrarMusicasEmCSharp(musicas);
		//LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
		//LinqOrder.ExibirListaDeArtistasOrdenados(musicas!);
		//LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
		//LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Tyga");
		//var musicasPreferidasDoMatheus = new MusicasPreferidas("Matheus");
		//musicasPreferidasDoMatheus.AdicionarMusicasFavoritas(musicas[1]);
  //      musicasPreferidasDoMatheus.AdicionarMusicasFavoritas(musicas[78]);
  //      musicasPreferidasDoMatheus.AdicionarMusicasFavoritas(musicas[899]);
  //      musicasPreferidasDoMatheus.AdicionarMusicasFavoritas(musicas[356]);
  //      musicasPreferidasDoMatheus.AdicionarMusicasFavoritas(musicas[775]);

		//musicasPreferidasDoMatheus.ExibirMusicasFavoritas();
		//musicasPreferidasDoMatheus.GerarArquivoJson();
    }
    catch (Exception ex)
	{
		Console.WriteLine($"Temos um problema: {ex.Message}"); ;
	}
}