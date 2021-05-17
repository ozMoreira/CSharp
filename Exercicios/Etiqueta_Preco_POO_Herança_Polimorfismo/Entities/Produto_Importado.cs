namespace Etiqueta_Preco_POO_Herança_Polimorfismo.Entities
{
    class Produto_Importado : Produto
    {
        public double TaxaImportacao { get; set; }

        public Produto_Importado()
        {
        }

        public Produto_Importado(string nome, double preco, double taxaImportacao)
            : base(nome, preco)
        {
            TaxaImportacao = taxaImportacao;
        }

        public double PrecoTotal()
        {
            return Preco + TaxaImportacao;
        }

        public override string EtiquetaPreco()
        {
            
            return $"{Nome} R$ {PrecoTotal().ToString("F2")} (Taxa de Importação: R$ {TaxaImportacao.ToString("F2")})";
        }
    }

   
}
