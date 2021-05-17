using Lista_Funcionarios_POO_Heranca_Polimorfismo.Entities;
using System;
using System.Collections.Generic;

namespace Lista_Funcionarios_POO_Heranca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Informe o número de funcionários >>> ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nInforme os dados do funcionário #{i}:");
                Console.Write("Terceirizado? (s/n) >>> ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome >>> ");
                string nome = Console.ReadLine();
                Console.Write("Horas >>> ");
                double horas = double.Parse(Console.ReadLine());
                Console.Write("Valor por Hora >>> R$ ");
                double valorHora = double.Parse(Console.ReadLine());

                if (ch == 's' || ch == 'S')
                {
                    Console.Write("Despesas Adicionais >>> R$ ");
                    double DespAdd = double.Parse(Console.ReadLine());
                    list.Add(new Funcionario_Terceirizado(nome, horas, valorHora, DespAdd));
                }
                else
                {
                    list.Add(new Funcionario(nome, horas, valorHora));
                }
            }

            Console.WriteLine("\nPAGAMENTOS");
            foreach (Funcionario func in list)
            {
                Console.WriteLine(func.Nome + " - R$ " + func.Pagamento().ToString("F2"));
            }
        }
    }
}
