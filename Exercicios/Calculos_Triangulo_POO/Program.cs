using System;

namespace Calculos_Triangulo_POO {
    class Program {
        static void Main(string[] args) {
            Retangulo r = new Retangulo();

            Console.WriteLine("Informe abaixo os dados do Retangulo!");
            Console.Write("Altura: >>> ");
            r.Altura = double.Parse(Console.ReadLine());
            Console.Write("Base: >>> ");
            r.Base = double.Parse(Console.ReadLine());

            Console.WriteLine(r);
        }
    }
}
