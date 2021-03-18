using System;

namespace crud_serie.views
{
    public class MenuView
    {
        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine("DIO SÉRIES!!!");
            Console.WriteLine("Informe a Opção Desejada!!!");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}