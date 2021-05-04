using System;

namespace Media_Salarial_POO {
    class Program {
        static void Main(string[] args) {

            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("\nDigite os dados do Primeiro Funcionario:");
            Console.Write("Nome >>> ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario >>> R$ ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite os dados do Segunda Funcionario:");
            Console.Write("Nome >>> ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario >>> R$ ");
            f2.salario = double.Parse(Console.ReadLine());

            double media = (f1.salario + f2.salario) / 2;

            Console.WriteLine("\n\n----------------------------------------------------------");
            Console.WriteLine("\nA média dos dois salarios é de R$ " + media.ToString("F2"));

        }
    }
}
