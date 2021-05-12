using System;

namespace Expressao_Condicional_Ternaria {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe um preço qualquer: >>> R$ ");
            double preco = double.Parse(Console.ReadLine());
            double desconto = (preco < 20.0) ? desconto = preco * 0.1 : desconto = preco * 0.5;
            Console.WriteLine(desconto);
        }
    }
}
