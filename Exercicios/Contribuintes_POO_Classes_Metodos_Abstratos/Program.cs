using Contribuintes_POO_Classes_Metodos_Abstratos.Entidades;
using System;
using System.Collections.Generic;

namespace Contribuintes_POO_Classes_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte>();

            Console.Write("Informe o número de contribuintes >>> ");
            int n = int.Parse(Console.ReadLine());  

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nDados do Contribuinte {i}:");
                Console.Write("Pessoa Física ou Jurídica? (PF/PJ) >>> ");
                string pessoa = Console.ReadLine();
                Console.Write("Nome >>> ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual >>> R$ ");
                double rendaAnual = double.Parse(Console.ReadLine());
                double impostos = 0;
                if (pessoa == "PF" || pessoa == "pf")
                {
                    Console.Write("Despesas Médicas >>> R$ ");
                    double despMedicas = double.Parse(Console.ReadLine());

                    if (rendaAnual < 20000.00)
                    {
                        impostos = 15.0;
                    }
                    else
                    {
                        impostos = 25.0;
                    }
                    list.Add(new PessoaFisica(nome, rendaAnual, despMedicas, impostos));
                }
                else
                {
                    Console.Write("Número total de funcionários >>> ");
                    int totalFuncionarios = int.Parse(Console.ReadLine());
                    if (totalFuncionarios > 10)
                    {
                        impostos = 14.0;
                    }
                    else
                    {
                        impostos = 16.0;
                    }
                    list.Add(new PessoaJuridica(nome, rendaAnual, totalFuncionarios, impostos));
                }
                Console.Clear();
            }

            Console.WriteLine("\n---- Impostos e Taxas Pagas ----");
            foreach (Contribuinte cont in list)
            {
                Console.WriteLine($"{cont.Nome}: R$ {cont.Taxa().ToString("F2")}");
            }

            double soma = 0;
            foreach (Contribuinte cont in list)
            {
                soma += cont.Taxa();
            }
            Console.WriteLine($"\n\n TOTAL DE TAXAS E IMPOSTOS PAGOS R$ {soma.ToString("F2")}");
        }
    }
}
