﻿using System;

namespace Calculadora_POO_Params {
    class Calculadora {
        public static int Soma(params int[] numeros) {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++) {
                soma += numeros[i];
            }
            return soma;
        }

        public static void Triplicar(ref int x) {
            x *= 3;
        }

        public static void Triplicou(int origin, out int result) {
            result = origin * 3;
        }
    }
}
