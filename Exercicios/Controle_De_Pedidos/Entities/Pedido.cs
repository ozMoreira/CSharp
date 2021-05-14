using Controle_De_Pedidos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controle_De_Pedidos.Entities
{
    class Pedido
    {
        public DateTime Instante { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Item { get; set; } = new List<ItemPedido>();

        public Pedido()
        {

        }

        public Pedido(DateTime instante, StatusPedido status, Cliente cliente)
        {
            Instante = instante;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(ItemPedido itemPedido)
        {
            Item.Add(itemPedido);
        }

        public void RemoveItem(ItemPedido itemPedido)
        {
            Item.Remove(itemPedido);
        }

        public double Total()
        {
            double soma = 0;
            foreach (ItemPedido item in Item)
            {
                soma += item.SubTotal();
            }
            return soma;
        }
        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            Console.Clear();
            sb.AppendLine("\n\n>>> RESUMO DO PEDIDO <<<");
            sb.Append("\nInstante do Pedido: ");
            sb.AppendLine(Instante.ToString("dd/MM/yyy HH:mm:ss"));
            sb.Append("Status do Pedido: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Cliente: ");
            sb.Append(Cliente.Nome);
            sb.Append(" (");
            sb.Append(Cliente.DataNascimento.ToString("dd/MM/yyy"));
            sb.Append(" ) - ");
            sb.AppendLine(Cliente.Email);
            sb.AppendLine("\nItens do Pedido");
            foreach (ItemPedido i in Item)
            {
                sb.Append(i.Produto.Nome);
                sb.Append(", R$ ");
                sb.Append(i.Preco.ToString("F2"));
                sb.Append(", Quantidade: ");
                sb.Append(i.Quantidade);
                sb.Append(", Subtotal: R$ ");
                sb.AppendLine(i.SubTotal().ToString("F2"));
                sb.Append("Valor Total: R$ ");
                sb.AppendLine(Total().ToString("F2"));
            }
            return sb.ToString();
        }
    }
}
