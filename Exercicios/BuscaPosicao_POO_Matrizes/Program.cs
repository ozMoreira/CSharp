using System;

namespace BuscaPosicao_POO_Matrizes {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira o Número de Linhas e Colunas da Matriz, separados por um espaço: >>> ");
            string[] dimensao = Console.ReadLine().Split(' ');
            int[,] matriz = new int[int.Parse(dimensao[0]), int.Parse(dimensao[1])];

            for (int l = 0; l < int.Parse(dimensao[0]); l++) {
                Console.Write("Insira uma sequencia de " + dimensao[1] + " números separados por espaço: >>> ");
                string[] valores = Console.ReadLine().Split(' ');
                for (int c = 0; c < int.Parse(dimensao[1]); c++) {
                    matriz[l, c] = int.Parse(valores[c]);
                }
            }
            Console.WriteLine("----------------------------------------------------");
            Console.Write("\n\n Informe um número da Matriz, para saber seus vizinhos: >>> ");
            int buscado = int.Parse(Console.ReadLine());

            for (int l = 0; l < int.Parse(dimensao[0]); l++) {
                for (int c = 0; c < int.Parse(dimensao[1]); c++) {
                    
                    if (matriz[l, c] == buscado) {
                        Console.WriteLine("\nEncontrado na posição " + l + "," + c);
                        int x = l - 1;
                        if (x >= 0) {
                            Console.WriteLine("Up: " + matriz.GetValue(x, c));
                        }
                        x = c + 1;
                        if (x <= int.Parse(dimensao[0])) {
                            Console.WriteLine("Right: " + matriz.GetValue(l, x));
                        }
                        x = l + 1;
                        if (x <= int.Parse(dimensao[1])) {
                            Console.WriteLine("Down: " + matriz.GetValue(x, c));
                        }
                        x = c - 1;
                        if (x >= 0) {
                            Console.WriteLine("left: " + matriz.GetValue(l, x));
                        }
                    }
                }
            }
        }
    }
}
