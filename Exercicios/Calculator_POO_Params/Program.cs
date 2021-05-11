using System;

namespace Calculadora_POO_Params {
    class Program {
        static void Main(string[] args) {
            int resultado = Calculadora.Soma(20, 30, 40);
            //int resultado = Calculadora.Soma(new int[] { 10, 20, 30, 40 }); --> Objeto Instanciado sem Params na funçao

            //Console.WriteLine(resultado);

            int a = 10;

            Calculadora.Triplicar(ref a); //--> busca a referencia na variavel da funcao void.
            Console.WriteLine(a);

            int b = 10;
            int triple;
            Calculadora.Triplicou(b, out triple); 
            Console.WriteLine(triple);
        }
    }
}
