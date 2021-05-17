namespace Etiqueta_Preco_POO_Herança_Polimorfismo.Entities
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

        public virtual string EtiquetaPreco()
        {
            
            return $"{Nome} R$ {Preco.ToString("F2")}";
        }
    }
}
