
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

               TabuleiroJogo tab = new TabuleiroJogo(8, 8);
               tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
               tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 3));
               tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));




               Posicao p = new Posicao(3, 4);



               Console.OutputEncoding = Encoding.UTF8;
               Tela.ImprimirTabuleiro(tab);

               Console.WriteLine("Posição: " + p);



           }
           catch (TabuleiroException e)
           {
               Console.WriteLine(e.Message);
           }
            /*  
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            */
            Console.ReadLine();
        }
    }
}
