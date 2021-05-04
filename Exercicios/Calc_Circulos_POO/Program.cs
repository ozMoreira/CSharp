using System;

namespace Calc_Circulos_POO {
    class Program {

        static double Pi = 3.14;
        static void Main(string[] args) {
            Console.Write("Entre com o valor do Raio: >>> ");
            double raio = double.Parse(Console.ReadLine());

            double circle = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circle.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Pi: " + Pi);
        }

        static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        static double Volume(double r) {
            return 4.0 / 3 * Pi * Math.Pow(r, 3);
        }

    }
}
