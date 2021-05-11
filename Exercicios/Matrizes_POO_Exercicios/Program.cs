using System;

namespace Matrizes_POO_Exercicios {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe um número que definirá o tamanho de cada dimensão da matriz: >>> ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int l = 0; l < n; l++) {
                Console.Write("Informe uma sequencia de " + n + " números, separado por espaço: >>>");
                string[] valores = Console.ReadLine().Split(' ');
                for (int c = 0; c < n; c++) {
                    mat[l, c] = int.Parse(valores[c]);
                }
            }

            Console.WriteLine("\nDiagonal Principal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }

            int contador = 0;
            for (int l = 0; l < n; l++) {
                for (int c = 0; c < n; c++) {
                    if (mat[l,c] < 0) {
                        contador++;
                    }
                }
            }
            Console.WriteLine("\n\nTotal de números negativos: " + contador);
        }
    }
}
