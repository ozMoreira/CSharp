using System;

namespace Conta_Bancaria_POO {
    class Program {
        static void Main(string[] args) {
            Conta c;

            Console.Write("Nome do Correntista >>> ");
            string nome = Console.ReadLine();

            Console.Write("Número da Conta Corrente >>> ");
            int cc = int.Parse(Console.ReadLine());

            Console.Write("Deseja fazer um deposito inicial? (s/n) >>> ");
            char opcao = char.Parse(Console.ReadLine());
            if (opcao == 's' || opcao =='S') {
                Console.Write("Informe o valor do deposito inicial: >>> R$ ");
                double deposita = double.Parse(Console.ReadLine());
                c = new Conta(nome, cc, deposita);
            } else {
                c = new Conta(nome, cc);
            }

            

            Console.Clear();
            Console.WriteLine(c);

            Console.WriteLine("\n\nDigite abaixo a opção desejada: \n1 - Deposito \n2 - Saque \n3 - Saldo \n0 - SAIR");
            Console.Write(">>> ");

            int opcao2 = int.Parse(Console.ReadLine());
            while (opcao2 != 0) {
                switch (opcao2) {
                    case 1:
                        Console.Write("\nInforme o valor dodo do deposito: >>> R$ ");
                        double deposita = double.Parse(Console.ReadLine());
                        c.Deposita(deposita);
                        Console.Clear();
                        Console.WriteLine(c);
                        break;
                    case 2:
                        Console.Write("\nInforme o valor a ser sacado: >>> R$ ");
                        double saque = double.Parse(Console.ReadLine());
                        c.Saca(saque);
                        Console.Clear();
                        Console.WriteLine(c);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(c);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA");
                        break;
                }
                
                Console.WriteLine("\n\nDigite abaixo a opção desejada: \n1 - Deposito \n2 - Saque \n3 - Saldo \n0 - SAIR");
                Console.Write(">>> ");
                opcao2 = int.Parse(Console.ReadLine());
            }
        }
    }
}
