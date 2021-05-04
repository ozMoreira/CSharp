using System;

namespace Estoque_Simples_POO {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: >>> ");
            string nome = Console.ReadLine();
            Console.Write("Preço: >>> R$ ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em Estoque: >>> ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("\n\nDados do Produto: " + p);

            Console.Write("\n\nDigite a quantidade de produtos a ser adicionados ao estoque: >>> ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionaProdutos(qtd);
            Console.WriteLine("\n\nDados Atualizados: " + p);

            Console.Write("\n\nDigite a quantidade de produtos a ser REMOVIDOS do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoveProdutos(qtd);
            Console.WriteLine("\n\nDados Atualizados: " + p);

        }
    }
}
