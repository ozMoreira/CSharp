using Tabuleiro;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(TabuleiroJogo tab, Cor cor) : base(tab, cor)
        {
                
        }
        public override string ToString()
        {
            //return "T";
            return "\u2656"; //Torre branco
        }
    }
}
