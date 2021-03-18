using System;
using crud_serie.classes;

namespace crud_serie.views
{
  public class ViewsSeries
  {
    static SerieRepositorio repositorio = new SerieRepositorio();
    public static void ListarSerie()
    {
      Console.WriteLine("*** LISTAR SÉRIE ***");

      var lista = repositorio.Lista();

      if (lista.Count == 0)
      {
        Console.WriteLine("\nNenhuma Série Cadastrada\n\n");
        return;
      }

      foreach (var serie in lista)
      {
        Console.WriteLine($"#ID {serie.getId()}: - {serie.getTitulo()}");
      }
    }
    public static void InserirSerie()
    {
      Console.WriteLine("*** INSERIR NOVA SÉRIE ***\n\n");

      var count = 1;
      foreach (var item in Enum.GetValues(typeof(Genero)))
      {
        //Console.WriteLine($"{item} - {Enum.GetName(typeof(Genero), item)}");
        Console.WriteLine("{0} - {1}", count++, Enum.GetName(typeof(Genero), item));
      }

        Console.WriteLine("\nDigite o gênero entre as opções acima");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o titulo da série");
        string entradaTitulo = Console.ReadLine();

        Console.WriteLine("Digite o ano de inicio da série");
        int entradaAno = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a descrição da série");
        string entradaDescricao = Console.ReadLine();

        Serie novaSerie = new Serie(
            id: repositorio.ProximoId(),
            genero: (Genero)entradaGenero,
            titulo: entradaTitulo,
            descricao: entradaDescricao,
            ano: entradaAno
        );

        repositorio.Inserir(novaSerie);
      
    }
    public static void AtualizarSerie() { }
    public static void ExcluirSerie() { }
    public static void VisualizarSerie() { }
  }
}