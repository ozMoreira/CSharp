using FormatoGeometrico_POO_Metodos_Abstratos.Entities;
using FormatoGeometrico_POO_Metodos_Abstratos.Entities.Enums;
using System;
using System.Collections.Generic;

namespace FormatoGeometrico_POO_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Formato> list = new List<Formato>();

            Console.Write("Qual a quantidade de Figuras Geométricas >>> ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Clear();
                Console.WriteLine($"\n Figura #{i}");
                Console.Write("Retangulo ou Circulo? (R/C) >>> ");
                char opcao = char.Parse(Console.ReadLine());
                Console.Write("Cor (Preto/Azul/Vermelho) >>> ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                if (opcao == 'R' || opcao == 'r')
                {
                    Console.Write("Largura >>> ");
                    double largura = double.Parse(Console.ReadLine());
                    Console.Write("Altura >>> ");
                    double altura = double.Parse(Console.ReadLine());

                    list.Add(new Retangulo(altura, largura, cor));
                }
                else
                {
                    Console.Write("Raio >>> ");
                    double raio = double.Parse(Console.ReadLine());

                    list.Add(new Circulo(raio, cor));
                }
            }

            Console.WriteLine("\n>>> FORMATOS GEOMÉTRICOS <<<");

            foreach (Formato formato in list)
            {
                Console.WriteLine(formato.Area().ToString("F2"));
            }

        }
    }
}
