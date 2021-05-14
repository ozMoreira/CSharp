using Controle_De_Pedidos.Entities;
using Controle_De_Pedidos.Entities.Enums;
using System;

namespace Controle_De_Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ SEJA BEM VINDO AO SISTEMA DE PEDIDOS ------");
            Console.WriteLine("\nEntre com os dados do Cliente");
            Console.Write("Nome >>> ");
            string tNome = Console.ReadLine();
            Console.Write("Email >>> ");
            string tEmail = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/AAA) >>> ");
            DateTime tNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com os dados do Pedido");
            Console.Write("Status >>> ");
            StatusPedido tStatus = Enum.Parse<StatusPedido>(Console.ReadLine());

            Cliente c = new Cliente(tNome, tEmail, tNascimento);
            Pedido p = new Pedido(DateTime.Now, tStatus, c);

            Console.Write("\n Quantidade de Itens do Pedido >>> ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Clear();
                Console.WriteLine("----ITENS DO PEDIDO----");
                Console.Write($"\nProduto {i}>>> ");
                string tProduto = Console.ReadLine();
                Console.Write("Preço >>> R$ ");
                double tPreco = double.Parse(Console.ReadLine());
                Console.Write("Quantidade >>> ");
                int tQtd = int.Parse(Console.ReadLine());

                Produto prod = new Produto(tProduto, tPreco);
                ItemPedido iP = new ItemPedido(prod, tQtd, tPreco);
                p.AddItem(iP);
                
            }
            Console.WriteLine(p);
        }
    }
}
