using System;

namespace Calculadora_POO_Params {
    class Program {
        static void Main(string[] args) {

            int resultado = Calculadora.Soma(new int[] { 10, 20, 30, 40 });

            Console.WriteLine(resultado);
        }
    }
}
