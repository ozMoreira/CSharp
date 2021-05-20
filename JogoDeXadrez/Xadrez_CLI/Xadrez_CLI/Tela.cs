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
                    if (tab.peca(l, c) == null)
                    {
                        Console.Write(" -");
                    }
                    else
                    {
                        ImprimirPeca(tab.peca(l, c));

                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------\n    A B C D E F G H");
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
