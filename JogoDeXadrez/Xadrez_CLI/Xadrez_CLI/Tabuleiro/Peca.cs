using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }

        public Cor cor { get; protected set; }

        public int QtdMovimentos { get; protected set; }

        public TabuleiroJogo tab { get; protected set; }

        public Peca(TabuleiroJogo tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.QtdMovimentos = 0;
        }

        public void IncrementaQtdMovimentos()
        {
            QtdMovimentos++;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossivels();
            for (int l = 0; l < tab.Linhas; l++)
            {
                for (int c = 0; c < tab.Linhas; c++)
                {
                    if (mat[l, c])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossivels()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossivels();

    }
}
