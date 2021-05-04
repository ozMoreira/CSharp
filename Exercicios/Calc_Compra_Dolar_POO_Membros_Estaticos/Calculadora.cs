using System;
using System.Collections.Generic;
using System.Text;

namespace Calc_Compra_Dolar_POO_Membros_Estaticos {
    class Calculadora {

        public static double Iof = 6.0;

        public static double ConverteDolar(double cotado, double desejado) {
            double convertido = (desejado * cotado);
            return (convertido * Iof) / 100 + convertido;

        }
    }
}
