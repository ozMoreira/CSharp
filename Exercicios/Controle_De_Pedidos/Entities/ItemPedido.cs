namespace Controle_De_Pedidos.Entities
{
    class ItemPedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public ItemPedido()
        {

        }

        public ItemPedido(Produto produto, int quantidade, double preco)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = preco;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }
    }
}
