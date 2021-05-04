using System;

namespace Ex_App_POO {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre abaixo com as medidas do triangulo 'X': ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre abaixo com as medidas do triangulo 'Y': ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("\n\nÁrea de 'X'  = " + areaX.ToString("F4"));
            Console.WriteLine("Área de 'y'  = " + areaY.ToString("F4"));

            if (areaX > areaY) {
                Console.WriteLine("\n\nMaior área é do Triângulo X");
            } else if (areaX == areaY) {
                Console.WriteLine("\n\nAmbos triangulos possuem a mesma área");
            } else {
                Console.WriteLine("\n\nMaior área é do Triangulo Y");
            }


        }
    }
}
