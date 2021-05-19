using Tabuleiro;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro_Jogo tab, Cor cor) : base(tab, cor)
        {
                
        }
        public override string ToString()
        {
            //return "T";
            return "\u2656"; //Torre branco
        }
    }
}
