using System;

namespace Arranjos_POO {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o número de lançamentos que deseja realizar: >>> ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Informe a altura >>> ");
                vect[i] = double.Parse(Console.ReadLine());
            }
            double sum = 0;
            for (int i = 0; i < vect.Length; i++) {
                sum += vect[i];
            }
            double avg = sum / n;
            Console.WriteLine("Média das alturas é de " + avg.ToString("f2"));
        }
    }
}
