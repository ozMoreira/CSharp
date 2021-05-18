using Tabuleiro;

namespace Xadrez_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro_Jogo tab = new Tabuleiro_Jogo(8, 8);

            Posicao p = new Posicao(3, 4);
            

            System.Console.WriteLine("Posição: " + p);

            Tela.ImprimirTabuleiro(tab);
        }
    }
}
