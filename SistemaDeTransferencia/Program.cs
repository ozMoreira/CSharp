
using System;
using System.Collections.Generic;

namespace SistemaDeTransferencia
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>();

        static void Main(string[] args)
        {
            string opcaoDesejada = MenuPrincipal();

            while (opcaoDesejada.ToUpper() != "X")
            {
                switch (opcaoDesejada)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirContas();
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
                        Console.WriteLine("Digite uma Opção Válida");
                        throw new ArgumentOutOfRangeException();
                }
                opcaoDesejada = MenuPrincipal();
            }
            
            Console.WriteLine("ViniBank agradece pela preferencia.");
            Console.ReadLine();
        }

        private static void Transferir()
        {
            Console.Write("Digite o Numero da Conta de ORIGEM: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o Número da Conta de DESTINO: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser TRANSFERIDO: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listaContas[indiceContaOrigem].Transferir(valorTransferencia, listaContas[indiceContaDestino]);
        }

        private static void Depositar()
        {
            Console.Write("Digite o Número da Conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Valor a Ser Depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Depositar(valorDeposito);    
        }

        private static void Sacar()
        {
            Console.Write("Digite o Número da Conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Valor a Ser Sacaddo: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Sacar(valorSaque);   
            }

        private static void ListarContas()
        {
            Console.WriteLine("Listar Contas");
            if (listaContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < listaContas.Count; i++)
            {
                Conta conta = listaContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta); 
            }
        }

        private static void InserirContas()
        {
            Console.Write("Digite 1 para Conta Fisica ou 2 para Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome Completo do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o saldo inicial do Investidor: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o Crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta (tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome);

            listaContas.Add(novaConta);
        }

        private static string MenuPrincipal()
        {
            Console.WriteLine();
            Console.WriteLine("Vinibank Corporation!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir Nova Conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - SAIR");
            Console.WriteLine();

            string opcaoDesejada = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoDesejada;
        }
    }
}
