using System;

namespace Arranjos2_POO {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe o número de produtos que deseja cadastrar >>> ");
            int n = int.Parse(Console.ReadLine());

            Produto[] pVect = new Produto[n];

            for (int i = 0; i < n; i++) {
                Console.Write("\nQual o nome do produto  >>> ");
                string name = Console.ReadLine();
                Console.Write("Informe o Preço de " + name + " >>> R$ ");
                double price = double.Parse(Console.ReadLine());
                pVect[i] = new Produto(name, price);
            }

            double somaP = 0;
            for (int i = 0; i < pVect.Length; i++) {
                somaP += pVect[i].Price;
            }

            double avg = somaP / n;
            Console.WriteLine("\n\nA média do preço dos produtos é R$ " + avg.ToString("F2"));
        }
    }
}
