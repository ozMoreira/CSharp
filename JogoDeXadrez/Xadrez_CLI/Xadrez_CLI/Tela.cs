using System;
using Tabuleiro;
using Xadrez;

namespace Xadrez_CLI
{
    class Tela
    {
        public static void ImprimirTabuleiro(TabuleiroJogo tab)
        {
            for (int l = 0; l < tab.Linhas; l++)
            {
                Console.Write(8 - l + "| ");
                for (int c = 0; c < tab.Colunas; c++)
                {
                    ImprimirPeca(tab.peca(l, c));
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------\n    A B C D E F G H");
        }

        public static void ImprimirTabuleiro(TabuleiroJogo tab, bool[,] posicoesPossiveis)
        {

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int l = 0; l < tab.Linhas; l++)
            {
                Console.Write(8 - l + "| ");
                for (int c = 0; c < tab.Colunas; c++)
                {
                    if (posicoesPossiveis[l, c])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    ImprimirPeca(tab.peca(l, c));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------\n    A B C D E F G H");
            Console.BackgroundColor = fundoOriginal;
        }
        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
        public static void ImprimirPeca(Peca peca)
        {

            if (peca == null)
            {
                Console.Write(" -");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca + " ");
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(peca + " ");
                    Console.ForegroundColor = aux;
                }

            }
        }
    }
}
