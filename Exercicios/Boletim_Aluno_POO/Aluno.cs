using System;
using System.Collections.Generic;
using System.Text;

namespace Boletim_Aluno_POO {
    class Aluno {

        public string Nome;
        public double N1, N2, N3;

        public double MediaFinal() {
            return ((N1 * 30) + (N2 * 35) + (N3 * 35)) / 100;
        }

        public bool Aprovado() {
            if (MediaFinal() > 6.0) {
                return true;
            } else {
                return false;
            }
        }

        public double MargemFaltante() {
            if (Aprovado()) {
                return 0.0;
            } else {
                return 6.0 - MediaFinal();
            }
        }

    }
}
