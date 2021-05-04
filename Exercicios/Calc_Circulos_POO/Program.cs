using System;

namespace Calc_Circulos_POO {
    class Program {

        
        static void Main(string[] args) {

            Console.Write("Entre com o valor do Raio: >>> ");
            double raio = double.Parse(Console.ReadLine());

            double circle = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circle.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Pi: " + Calculadora.Pi);
        }

    }
}
