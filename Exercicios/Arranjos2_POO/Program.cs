using System;

namespace Arranjos2_POO {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe o número de produtos que deseja cadastrar >>> ");
            int n = int.Parse(Console.ReadLine());
            double[] pVect = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("\nQual o nome do produto  >>> ");
                string prod = Console.ReadLine();
                Console.Write("Informe o Preço de " + prod + " >>> R$ ");
                pVect[i] = double.Parse(Console.ReadLine());
            }

            double somaP = 0;
            for (int i = 0; i < pVect.Length; i++) {
                somaP += pVect[i];
            }

            double avg = somaP / n;
            Console.WriteLine("\n\nA média do preço dos produtos " + avg.ToString("F2"));
        }
    }
}
