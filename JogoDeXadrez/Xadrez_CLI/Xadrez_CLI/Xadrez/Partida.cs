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
        public bool Xeque { get; private set; }


        public Partida()
        {
            tab = new TabuleiroJogo(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            Xeque = false;
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
            SobeJogo();
        }

        public Peca ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetiraPeca(origem);
            p.IncrementaQtdMovimentos();
            Peca pecaCapturada = tab.RetiraPeca(destino);
            tab.ColocarPeca(p, destino);
            if (pecaCapturada != null)
            {
                capturadas.Add(pecaCapturada);
            }

            //#Combo Roque Pequeno
            if (p is Rei && destino.Coluna == origem.Coluna + 2)
            {
                Posicao origemTorre = new Posicao(origem.Linha, origem.Coluna + 3);
                Posicao destinoTorre = new Posicao(origem.Linha, origem.Coluna + 1);
                Peca T = tab.RetiraPeca(origemTorre);
                T.IncrementaQtdMovimentos();
                tab.ColocarPeca(T, destinoTorre);
            }
            //#Combo Roque Grande
            if (p is Rei && destino.Coluna == origem.Coluna - 2)
            {
                Posicao origemTorre = new Posicao(origem.Linha, origem.Coluna - 4);
                Posicao destinoTorre = new Posicao(origem.Linha, origem.Coluna - 1);
                Peca T = tab.RetiraPeca(origemTorre);
                T.IncrementaQtdMovimentos();
                tab.ColocarPeca(T, destinoTorre);
            }
            return pecaCapturada;
        }

        public void DesfazMovimento(Posicao origem, Posicao destino, Peca pecaCapturada)
        {
            Peca p = tab.RetiraPeca(destino);
            p.DecrementaQtdMovimentos();
            if (pecaCapturada != null)
            {
                tab.ColocarPeca(pecaCapturada, destino);
                capturadas.Remove(pecaCapturada);
            }
            tab.ColocarPeca(p, origem);

            //#Combo Roque Pequeno
            if (p is Rei && destino.Coluna == origem.Coluna + 2)
            {
                Posicao origemTorre = new Posicao(origem.Linha, origem.Coluna + 3);
                Posicao destinoTorre = new Posicao(origem.Linha, origem.Coluna + 1);
                Peca T = tab.RetiraPeca(destinoTorre);
                T.DecrementaQtdMovimentos();
                tab.ColocarPeca(T, origemTorre);
            }
            //#Combo Roque Grande
            if (p is Rei && destino.Coluna == origem.Coluna - 2)
            {
                Posicao origemTorre = new Posicao(origem.Linha, origem.Coluna - 4);
                Posicao destinoTorre = new Posicao(origem.Linha, origem.Coluna - 1);
                Peca T = tab.RetiraPeca(destinoTorre);
                T.IncrementaQtdMovimentos();
                tab.ColocarPeca(T, origemTorre);
            }
        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            Peca pecaCapturada = ExecutaMovimento(origem, destino);
            if (EstaEmXeque(JogadorAtual))
            {
                DesfazMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você nao pode se colocar em Xeque!");
            }

            if (EstaEmXeque(Adversaria(JogadorAtual)))
            {
                Xeque = true;
            }
            else
            {
                Xeque = false;
            }

            if (TesteXequeMate(Adversaria(JogadorAtual)))
            {
                Terminada = true;
            }
            else
            {
                Turno++;
                MudaJogador();
            }
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
            if (!tab.peca(origem).MovimentoPossivel(destino))
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
            foreach (Peca x in pecas)
            {
                if (x.cor == cor)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(pecasCapturadas(cor));
            return aux;

        }

        private Cor Adversaria(Cor cor)
        {
            if (cor == Cor.Branca)
            {
                return Cor.Preta;
            }
            else
            {
                return Cor.Branca;
            }
        }

        private Peca rei(Cor cor)
        {
            foreach (Peca x in PecasEmJogo(cor))
            {
                if (x is Rei)
                {
                    return x;
                }
            }
            return null;
        }

        public bool EstaEmXeque(Cor cor)
        {
            Peca R = rei(cor);
            if (R == null)
            {
                throw new TabuleiroException("Este REI já morreu!");
            }
            foreach (Peca x in PecasEmJogo(Adversaria(cor)))
            {
                bool[,] mat = x.MovimentosPossivels();
                if (mat[R.posicao.Linha, R.posicao.Coluna])
                {
                    return true;
                }
            }
            return false;
        }

        public bool TesteXequeMate(Cor cor)
        {
            if (!EstaEmXeque(cor))
            {
                return false;
            }
            foreach (Peca x in PecasEmJogo(cor))
            {
                bool[,] mat = x.MovimentosPossivels();
                for (int l = 0; l < tab.Linhas; l++)
                {
                    for (int c = 0; c < tab.Colunas; c++)
                    {
                        if (mat[l, c])
                        {
                            Posicao origem = x.posicao;
                            Posicao destino = new Posicao(l, c);
                            Peca pecaCapturada = ExecutaMovimento(origem, destino);
                            bool testeXeque = EstaEmXeque(cor);
                            DesfazMovimento(origem, destino, pecaCapturada);
                            if (!testeXeque)
                            {
                                return false;
                            }

                        }
                    }
                }
            }
            return true;
        }

        public void ColocaNovaPeca(char coluna, int linha, Peca peca)
        {
            tab.ColocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            pecas.Add(peca);
        }

        private void SobeJogo()
        {
            ColocaNovaPeca('a', 1, new Torre(tab, Cor.Branca));
            ColocaNovaPeca('b', 1, new Cavalo(tab, Cor.Branca));
            ColocaNovaPeca('c', 1, new Bispo(tab, Cor.Branca));
            ColocaNovaPeca('d', 1, new Rainha(tab, Cor.Branca));
            ColocaNovaPeca('e', 1, new Rei(tab, Cor.Branca, this));
            ColocaNovaPeca('f', 1, new Bispo(tab, Cor.Branca));
            ColocaNovaPeca('g', 1, new Cavalo(tab, Cor.Branca));
            ColocaNovaPeca('h', 1, new Torre(tab, Cor.Branca));
            ColocaNovaPeca('a', 2, new Peao(tab, Cor.Branca));
            ColocaNovaPeca('b', 2, new Peao(tab, Cor.Branca));
            ColocaNovaPeca('c', 2, new Peao(tab, Cor.Branca));
            ColocaNovaPeca('d', 2, new Peao(tab, Cor.Branca));
            ColocaNovaPeca('e', 2, new Peao(tab, Cor.Branca));
            ColocaNovaPeca('f', 2, new Peao(tab, Cor.Branca));
            ColocaNovaPeca('g', 2, new Peao(tab, Cor.Branca));
            ColocaNovaPeca('h', 2, new Peao(tab, Cor.Branca));

            ColocaNovaPeca('a', 8, new Torre(tab, Cor.Preta));
            ColocaNovaPeca('b', 8, new Cavalo(tab, Cor.Preta));
            ColocaNovaPeca('c', 8, new Bispo(tab, Cor.Preta));
            ColocaNovaPeca('d', 8, new Rainha(tab, Cor.Preta));
            ColocaNovaPeca('e', 8, new Rei(tab, Cor.Preta, this));
            ColocaNovaPeca('f', 8, new Bispo(tab, Cor.Preta));
            ColocaNovaPeca('g', 8, new Cavalo(tab, Cor.Preta));
            ColocaNovaPeca('h', 8, new Torre(tab, Cor.Preta));
            ColocaNovaPeca('a', 7, new Peao(tab, Cor.Preta));
            ColocaNovaPeca('b', 7, new Peao(tab, Cor.Preta));
            ColocaNovaPeca('c', 7, new Peao(tab, Cor.Preta));
            ColocaNovaPeca('d', 7, new Peao(tab, Cor.Preta));
            ColocaNovaPeca('e', 7, new Peao(tab, Cor.Preta));
            ColocaNovaPeca('f', 7, new Peao(tab, Cor.Preta));
            ColocaNovaPeca('g', 7, new Peao(tab, Cor.Preta));
            ColocaNovaPeca('h', 7, new Peao(tab, Cor.Preta));
            /*
            //Posicao para testar xeque mate
            ColocaNovaPeca('c', 1, new Torre(tab, Cor.Branca));
            ColocaNovaPeca('d', 1, new Rei(tab, Cor.Branca));
            ColocaNovaPeca('h', 7, new Torre(tab, Cor.Branca));

            ColocaNovaPeca('a', 8, new Rei(tab, Cor.Preta));
            ColocaNovaPeca('b', 8, new Torre(tab, Cor.Preta));
            */


        }
    }
}
