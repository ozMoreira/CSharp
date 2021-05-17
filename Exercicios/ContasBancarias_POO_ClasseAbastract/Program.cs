using ContasBancarias_POO_ClasseAbastract.Entities;
using System.Collections.Generic;

namespace ContasBancarias_POO_ClasseAbastract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> list = new List<Conta>();
            list.Add(new Poupanca(1001, "Alex", 500.00, 0.01));
            list.Add(new ContaCorporativa(1002, "Maria", 500.00, 400.00));
            list.Add(new Poupanca(1003, "Bob", 500.00, 0.01));
            list.Add(new ContaCorporativa(1004, "Anna", 500.00, 500.00));

            

            double soma = 0.0;
            foreach (Conta c in list)
            {
                soma += c.Saldo;
            }

            System.Console.WriteLine($"Saldo Total -> R$ {soma.ToString("F2")}");

            foreach (Conta c in list)
            {
                c.Saque(10.00);
            }

            foreach (Conta c in list)
            {
                System.Console.WriteLine($"Saldo Atualizao para a Conta {c.Numero} -> R$ {c.Saldo.ToString("F2")}");
            }
        }
    }
}
