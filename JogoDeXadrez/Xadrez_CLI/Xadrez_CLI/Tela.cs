using System;
using Tabuleiro;

namespace Xadrez_CLI
{
    class Tela
    {
        public static void ImprimirTabuleiro(TabuleiroJogo tab)
        {
            for (int l = 0; l < tab.Linhas; l++)
            {
                for (int c = 0; c < tab.Colunas; c++)
                {
                    if (tab.peca(l, c) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(l, c) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
