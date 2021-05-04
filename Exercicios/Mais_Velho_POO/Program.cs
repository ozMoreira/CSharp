using System;

namespace Mais_Velho_POO {
    class Program {
        static void Main(string[] args) {
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();
            int opcao = 1;

            while (opcao != 0){
                Console.Clear();
                Console.WriteLine("\n\nDigite abaixo os dados da Primeira Pessoa!");
                Console.Write("Nome: ");
                pessoa1.Nome = Console.ReadLine();
                Console.Write("Idade: ");
                pessoa1.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\nDigite abaixo os dados da Segunda Pessoa!");
                Console.Write("Nome: ");
                pessoa2.Nome = Console.ReadLine();
                Console.Write("Idade: ");
                pessoa2.Idade = int.Parse(Console.ReadLine());

                if (pessoa2.Idade > pessoa1.Idade) {
                    Console.WriteLine("\nA pessoa de nome " + pessoa2.Nome + " é a mais velha!");
                } else {
                    Console.WriteLine("\nNesse caso, " + pessoa1.Nome + " é a pessoa mais velha!");
                }
                
                Console.WriteLine("\n\nDeseja fazer outra comparação?    1 - SIM / 0 - Não");
                Console.Write(">>> ");
                opcao = int.Parse(Console.ReadLine());
            }

        }
    }
}
