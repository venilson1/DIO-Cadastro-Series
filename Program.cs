using System;
using crud_serie.views;

namespace crud_serie
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = MenuView.ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    ViewsSeries.ListarSerie();
                    break;

                    case "2":
                    ViewsSeries.InserirSerie();
                    break;

                    case "3":
                    ViewsSeries.AtualizarSerie();
                    break;

                    case "4":
                    ViewsSeries.ExcluirSerie();
                    break;

                    case "5":
                    ViewsSeries.VisualizarSerie();
                    break;

                    case "C":
                    Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = MenuView.ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado!!!");
            Console.ReadLine();
        }

    }
}
