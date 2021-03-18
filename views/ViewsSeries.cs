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
        public static void InserirSerie(){ }
        public static void AtualizarSerie(){ }
        public static void ExcluirSerie(){ }
        public static void VisualizarSerie(){ }
    }
}