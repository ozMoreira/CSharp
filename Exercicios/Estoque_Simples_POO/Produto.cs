namespace Estoque_Simples_POO {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Propriedade que substitui o get / set
        public string Nome {
            get { return _nome; }
            set { if (value != null && value.Length > 1) {
                    _nome = value; }
            }
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionaProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoveProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome +
                "\nPreço Unitário: R$ " + Preco.ToString("F2") +
                "\nQuantidade Disponível: " + Quantidade +
                "\nValor Total do Estoque: R$ " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
