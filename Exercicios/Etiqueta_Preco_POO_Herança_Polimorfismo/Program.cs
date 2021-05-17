using Etiqueta_Preco_POO_Herança_Polimorfismo.Entities;
using System;
using System.Collections.Generic;

namespace Etiqueta_Preco_POO_Herança_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            Console.Write("Informe o número de produtos a registrar >>> ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.Clear();
                Console.WriteLine($"\nDados do Produto {i}:");
                Console.Write("Novo, Usado ou Importado? (n/u/i) >>> ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome >>> ");
                string nome = Console.ReadLine();
                Console.Write("Preço >>> R$ ");
                double preco = double.Parse(Console.ReadLine());
                
                if (tipo == 'u' || tipo == 'U')
                {
                    Console.Write("Data de Fabricação >>> ");
                    DateTime dt = DateTime.Parse(Console.ReadLine());
                    list.Add(new Produto_Usado(nome, preco, dt));
                    
                }
                else if (tipo =='i' || tipo == 'I')
                {
                    Console.Write("Taxa de Importação >>> R$ ");
                    double taxaImp = double.Parse(Console.ReadLine());

                    list.Add(new Produto_Importado(nome, preco, taxaImp));
                }
                else
                {
                    list.Add(new Produto(nome, preco));
                }
            }
            Console.Clear();
            Console.WriteLine("\n --- ETIQUETA DE PREÇOS ---");
            foreach (Produto prod in list)
            {
                Console.WriteLine(prod.EtiquetaPreco());
            }

        }
    }
}
