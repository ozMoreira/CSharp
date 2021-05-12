using System;

namespace Switch_Case {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe um número de 1 a 7: >>> ");
            int x = int.Parse(Console.ReadLine());
            string dia;
            /*
            if (x == 1) {
                dia = "Domingo";
            } else if (x == 2) {
                dia = "Segunda-Feira";
            } else if (x == 3) {
                dia = "Terça-Feira";
            } else if (x == 4) {
                dia = "Quarta-Feira";
            } else if (x == 5) {
                dia = "Quinta-Feira";
            } else if (x == 6) {
                dia = "Sexta-Feira";
            } else if (x == 7) {
                dia = "Sabado";
            } else {
                dia = "Valor Inválido";
            }
            */
            switch (x) {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda-Feira";
                    break;
                case 3:
                    dia = "Terça-Feira";
                    break;
                case 4:
                    dia = "Quarta-Feira";
                    break;
                case 5:
                    dia = "Quinta-Feira";
                    break;
                case 6:
                    dia = "Sexta-Feira";
                    break;
                case 7:
                    dia = "Sabado";
                    break;
                default:
                    dia = "Valor inválido";
                    break;

            }
            Console.WriteLine("Dia: " + dia);
        }
    }
}

