using System;

namespace Conta_Bancaria_POO {
    class Program {
        static void Main(string[] args) {
            Console.Write("Nome do Correntista >>> ");
            string nome = Console.ReadLine();

            Console.Write("Número da Conta Corrente >>> ");
            int cc = int.Parse(Console.ReadLine());

            Console.Write("Deseja fazer um deposito inicial? (s/n)");
            string depInicial = Console.ReadLine();
            
            if (depInicial == "s") {
                Console.Write("Informe o valor do deposito inicial: >>> R$ ");
                int deposita = int.Parse(Console.ReadLine());
            }

            Conta c = new Conta(nome, cc);

            Console.WriteLine(c);
        }
    }
}
