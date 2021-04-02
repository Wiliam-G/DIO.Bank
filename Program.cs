
using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaousuario = ObterOpcaoUsuario();
            while(opcaousuario.ToUpper() != "X")
            {
                switch (opcaousuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        Environment.Exit(0);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                       
                }
                opcaousuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utulizar nossos serviços.");
            Console.WriteLine();


        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Dio Bank a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar a tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaousuario = Console.ReadLine();
            Console.WriteLine();
            return opcaousuario;
        }
    }
}
