using Tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(TabuleiroJogo tab, Cor cor) : base(tab, cor)
        {
                
        }
        public override string ToString()
        {
           
               // return "\u265A"; //Rei Preto
        
                return "\u2654"; //Rei Branco

            //return "R";
           
        }
    }
}
