using System;

namespace Aumento_Salarial_POO {
    class Program {
        static void Main(string[] args) {
            Funcionario f = new Funcionario();

            Console.WriteLine("Insira os dados do Funcionário");
            Console.Write("Nome >>> ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto >>> R$ ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Impostos Descontados na Folha >>> R$ ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("\nFuncionario: " + f);

            Console.Write("\nInforme o Percentual que o funcionário terá de aumento salarial: (%) >>> ");
            double percent = double.Parse(Console.ReadLine());
            f.AumentarSalario(percent);

            Console.WriteLine("\nFuncionario atualizado: " + f);
        }
    }
}
