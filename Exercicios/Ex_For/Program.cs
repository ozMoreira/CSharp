using System;

namespace Ex_For {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos números voce deseja digitar? >>> ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for(int i = 1; i <= n; i++) {
                Console.Write("\nInforme o número " + i + ">>> ");
                int x = int.Parse(Console.ReadLine());
                soma += x;
            }
            Console.WriteLine("\n\nA soma dos números informados é " + soma);

        }
    }
}
