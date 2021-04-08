﻿
using System;
using System.Collections.Generic;


namespace DIO.Bank
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>();
        static void Main(string[] args)
        {
            
            string opcaousuario = ObterOpcaoUsuario();
            while(opcaousuario.ToUpper() != "X")
            {
                switch (opcaousuario.ToUpper())
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

                    default:
                        throw new ArgumentOutOfRangeException();
                       
                }
                opcaousuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utulizar nossos serviços.");
            Console.WriteLine();

        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");

            if(listaContas.Count == 0)
            {
                Console.WriteLine("Não há contas cadastradas");
                return;
            }

          for (int i = 0; i < listaContas.Count; i++)
            {
                Conta conta = listaContas[i];
                Console.Write("#[0] - ", i);
                Console.WriteLine(conta);
            }
        }
        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");

            Console.WriteLine("Digite 1 para conta física ou 2 para jurídica");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                saldo: entradaSaldo,
                credito: entradaCredito,
                nome: entradaNome);

            listaContas.Add(novaConta);
        }
        private static void Transferir()
        {
            Console.WriteLine("Digite o número da conta de origem: ");
            int IndiceContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listaContas[IndiceContaOrigem].Transferir(valorTransferencia, listaContas[indiceContaDestino]);
        }
        private static void Sacar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int IndiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listaContas[IndiceConta].Sacar(valorSaque);
        }

        private static void Depositar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int IndiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listaContas[IndiceConta].Depositar(valorDeposito);
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
