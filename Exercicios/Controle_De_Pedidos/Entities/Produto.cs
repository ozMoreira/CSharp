namespace Controle_De_Pedidos.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }


        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
