namespace Estoque_Simples_POO {
    class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome() {
            return _nome;
        }

        public int getQuantidade() {
            return _quantidade;
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) { 
            _nome = nome;
            }
        }

        public double GetPreco() {
            return _preco;
        }

        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        public void AdicionaProdutos(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoveProdutos(int quantidade) {
            _quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome +
                "\nPreço Unitário: R$ " + _preco.ToString("F2") +
                "\nQuantidade Disponível: " + _quantidade +
                "\nValor Total do Estoque: R$ " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
