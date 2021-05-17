using System;
using ContaBancaria_Herança_POO.Entities;
namespace Herança_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta(1001, "Alex", 500.0); 
            //ContaCorporativa cCorp = new ContaCorporativa(1002, "Maria", 0.0, 500.00);
            
            //UPCASTING Super Classe recebe subClasse
            //Conta c2 = cCorp;
            Conta c3 = new ContaCorporativa(1003, "Bob", 0.0, 200.0);
            Conta c4 = new Poupanca(1004, "Anna", 500.0, 0.01);

            c.Saque(10.0);
            c4.Saque(10.0);

            Console.WriteLine(c.Saldo);
            Console.WriteLine(c4.Saldo);
            /*
            //DOWNCASTING
            ContaCorporativa cCorp2 = (ContaCorporativa)c3;
            cCorp2.Emprestimo(100);

            //ContaCorporativa cCorp3 = (ContaCorporativa)c4; - Nao Pode
            if (c4 is ContaCorporativa)
            {
                //ContaCorporativa cCorp3 = (ContaCorporativa)c4; - Sintaxe Alternativa para Casting
                ContaCorporativa cCorp3 = c4 as ContaCorporativa;
                cCorp3.Emprestimo(200.00);
                Console.WriteLine("Emprestimo Realizado");
            }
            if (c4 is Poupanca)
            {
                Poupanca cCorp3 = (Poupanca)c4;
                cCorp3.AtualizaSaldo();
                Console.WriteLine("Atualizado Saldo");
            }*/
        }
    }
}
