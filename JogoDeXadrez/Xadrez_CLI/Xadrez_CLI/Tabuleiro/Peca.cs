using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }

        public Cor cor { get; protected set; }

        public int QtdMovimentos { get; protected set; }

        public Tabuleiro_Jogo tab { get; protected set; }

        public Peca(Tabuleiro_Jogo tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.QtdMovimentos = 0;
        }
    }
}
