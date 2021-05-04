using System;

namespace Calc_Compra_Dolar_POO_Membros_Estaticos {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do Dólar? >>> U$D ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares deseja comprar? >>> U$D ");
            double dolarDesejado = double.Parse(Console.ReadLine());

            Console.WriteLine("\nValor a ser pago em Reais: R$ " +
                Calculadora.ConverteDolar(cotacao, dolarDesejado).ToString("F2"));
        }
    }
}
