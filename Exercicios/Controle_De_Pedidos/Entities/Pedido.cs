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
    }
}
