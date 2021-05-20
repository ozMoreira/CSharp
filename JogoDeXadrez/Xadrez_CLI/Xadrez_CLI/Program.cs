
using System.Text;
using Tabuleiro;
using Xadrez;
using System;
namespace Xadrez_CLI
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Partida partida = new Partida();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);
                    Console.Write("\nOrigem: >>> ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();

                    bool[,] PosicoesPossiveis = partida.tab.peca(origem).MovimentosPossivels();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab, PosicoesPossiveis);

                    
                    Console.Write("\nDestino: >>> ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
