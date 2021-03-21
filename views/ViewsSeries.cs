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
        Console.WriteLine("\nNenhuma Série Cadastrada\n");
        return;
      }

      

      foreach (var serie in lista)
      {
        var excluido = serie.getExcluido();
        Console.WriteLine($"#ID {serie.getId()}: - {serie.getTitulo()} - Excluido: {excluido}");
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
    public static void AtualizarSerie()
    {
      Console.WriteLine("*** INSERIR NOVA SÉRIE ***\n\n");

      Console.WriteLine("Digite o id da série");
      int entradaId = int.Parse(Console.ReadLine());

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

      Serie atualizaSerie = new Serie(
          id: entradaId,
          genero: (Genero)entradaGenero,
          titulo: entradaTitulo,
          descricao: entradaDescricao,
          ano: entradaAno
      );

      repositorio.Atualizar(entradaId, atualizaSerie);
    }
    public static void ExcluirSerie() 
    { 
      Console.WriteLine("*** EXCLUIR SÉRIE ***\n\n");

      Console.WriteLine("\n");
      ViewsSeries.ListarSerie();
      Console.WriteLine("\n");

      Console.WriteLine("Digite o Id da série que deseja excluir");
      int entradaId = int.Parse(Console.ReadLine());

      
      repositorio.Excluir(entradaId); 
      
    } 
    public static void VisualizarSerie() 
    { 
      Console.WriteLine("*** VISUALIZAR SÉRIE ***\n\n");

      Console.WriteLine("Digite o Id da série que deseja visualizar");
      int entradaId = int.Parse(Console.ReadLine());

      var serie = repositorio.RetornaPorId(entradaId);

      Console.WriteLine(serie);
    }
  }
}