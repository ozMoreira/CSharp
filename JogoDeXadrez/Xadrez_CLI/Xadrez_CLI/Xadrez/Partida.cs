using Tabuleiro;
using System.Collections.Generic;

namespace Xadrez
{
    class Partida
    {
        public TabuleiroJogo tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;


        public Partida()
        {
            tab = new TabuleiroJogo(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
            SobeJogo();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetiraPeca(origem);
            p.IncrementaQtdMovimentos();
            Peca pecaCapturada = tab.RetiraPeca(destino);
            tab.ColocarPeca(p, destino);
            if (pecaCapturada != null)
            {
                capturadas.Add(pecaCapturada);
            }
        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            Turno++;
            MudaJogador();
        }

        public void ValidaPosicaoOrigem(Posicao pos)
        {
            if (tab.peca(pos) == null)
            {
                throw new TabuleiroException("Posição vazia!");
            }
            if (JogadorAtual != tab.peca(pos).cor)
            {
                throw new TabuleiroException("Aguarde seu turno para jogar!");
            }
            if (!tab.peca(pos).ExisteMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possíveis para esta peça");
            }
        }

        public void ValidaPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).PodeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de Destino INVALIDA!");
            }
        }

        private void MudaJogador()
        {
            if (JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
        }

        public HashSet<Peca> pecasCapturadas(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in capturadas)
            {
                if (x.cor == cor)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Peca> PecasEmJogo(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in capturadas)
            {
                if (x.cor == cor)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(pecasCapturadas(cor));
            return aux;
        }

        public void ColocaNovaPeca(char coluna, int linha, Peca peca)
        {
            tab.ColocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            pecas.Add(peca);
        }

        private void SobeJogo()
        {
            //Brancas   
            ColocaNovaPeca('c', 1, new Torre(tab, Cor.Branca));
            ColocaNovaPeca('c', 2, new Torre(tab, Cor.Branca));
            ColocaNovaPeca('d', 2, new Torre(tab, Cor.Branca));
            ColocaNovaPeca('e', 2, new Torre(tab, Cor.Branca));
            ColocaNovaPeca('e', 1, new Torre(tab, Cor.Branca));
            ColocaNovaPeca('d', 1, new Rei(tab, Cor.Branca));

            //Pretas
            ColocaNovaPeca('c', 7, new Torre(tab, Cor.Preta));
            ColocaNovaPeca('c', 8, new Torre(tab, Cor.Preta));
            ColocaNovaPeca('d', 7, new Torre(tab, Cor.Preta));
            ColocaNovaPeca('e', 7, new Torre(tab, Cor.Preta));
            ColocaNovaPeca('e', 8, new Torre(tab, Cor.Preta));
            ColocaNovaPeca('d', 8, new Rei(tab, Cor.Preta));


        }
    }
}
