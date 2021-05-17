using System;
using System.Collections.Generic;
using System.Text;

namespace Etiqueta_Preco_POO_Herança_Polimorfismo.Entities
{
    class Produto_Usado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public Produto_Usado()
        {
        }

        public Produto_Usado(string nome, double preco, DateTime dataFabricacao)
            : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string EtiquetaPreco()
        {
            return base.EtiquetaPreco() + $" (Data de Fabricação: {DataFabricacao.ToString("dd/MM/yyyy")})";
        }
    }
}
