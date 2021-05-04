using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque_Simples_POO {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
            return Nome +
                "\nPreço Unitário: R$ " + Preco.ToString("F2") +
                "\nQuantidade Disponível: " + Quantidade + 
                "\nValor Total do Estoque: R$ " + ValorTotalEmEstoque().ToString("F2");
        }

      

    }
}
