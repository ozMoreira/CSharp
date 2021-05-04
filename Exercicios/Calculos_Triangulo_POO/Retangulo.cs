using System;

namespace Calculos_Triangulo_POO {
    class Retangulo {
        public double Altura;
        public double Base;

        public double CalculaArea() {
            return Base * Altura;
        }

        public double CalculaPerimetro() {
            return (Base + Altura) * 2;
        }

        public double CalculaDiagonal() {
            return Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString() {
            return "\nÁrea = " + CalculaArea().ToString("F2")
                    + "\nPerimetro = " + CalculaPerimetro().ToString("F2")
                    + "\nDiagonal = " + CalculaDiagonal().ToString("F2");
        }
    }
}
