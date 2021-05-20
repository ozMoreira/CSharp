using Tabuleiro;

namespace Xadrez
{
    class Bispo : Peca
    {
        public Bispo(TabuleiroJogo tab, Cor cor)
            : base(tab, cor)
        {
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] MovimentosPossivels()
        {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //NW
            pos.DefiniValores(posicao.Linha -1, posicao.Coluna - 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefiniValores(pos.Linha - 1, pos.Coluna - 1);
            }

            //NE
            pos.DefiniValores(posicao.Linha - 1, posicao.Coluna + 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefiniValores(pos.Linha - 1, pos.Coluna + 1);
            }

            //SE
            pos.DefiniValores(posicao.Linha + 1, posicao.Coluna + 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefiniValores(pos.Linha + 1, pos.Coluna + 1);
            }

            //SW
            pos.DefiniValores(posicao.Linha + 1, posicao.Coluna - 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefiniValores(pos.Linha + 1, pos.Coluna - 1);
            }
            return mat;

        }

        public override string ToString()
        {
            return "\u2657";
        }

    }
}
