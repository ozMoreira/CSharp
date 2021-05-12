namespace BuscaPosicao_POO_Matrizes {
    class Ponto {

        public int Point { get; set; }
        public int Pup { get; set; }

        public int PRight { get; set; }

        public int PDown { get; set; }

        public int PLeft { get; set; }

        public Ponto(int point, int pup, int pRight, int pDown, int pLeft) {
            Point = point;
            Pup = pup;
            PRight = pRight;
            PDown = pDown;
            PLeft = pLeft;
        }

        public override string ToString() {
            return base.ToString(); 
        }
    }
}
