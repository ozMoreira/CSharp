using System;

namespace Reservas_Hotel_POO_Arranjos {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe o número de quartos para ocupar: >>> ");
            int quartos = int.Parse(Console.ReadLine());
            Reserva[] resV = new Reserva[10];
            if (quartos <= 10) {
                for (int i = 0; i < quartos; i++) {
                    int saldo = quartos - i;
                    Console.WriteLine("Faltam ainda " + saldo + " lançamentos!!!");
                    Console.Write("\nNome do Hospede: >>> ");
                    string hospede = Console.ReadLine();

                    Console.Write("E-mail de contato: >>> ");
                    string emailContato = Console.ReadLine();

                    Random rd = new Random();
                    int x = rd.Next(10);

                    if (resV[x] == null) {
                        resV[x] = new Reserva(i, hospede, emailContato, x);
                    } else {
                        x = rd.Next(10);
                        while (resV[x] != null) {
                            x = rd.Next(10);
                        }
                        resV[x] = new Reserva(i, hospede, emailContato, x);
                    }
                    Console.Clear();
                }
            } else {
                Console.WriteLine("\n\nNúmero de Quartos desejados Maior que o Disponível");
            }
            for (int p = 0; p < 10; p++) {
                if (resV[p] != null) {
                    Console.WriteLine(resV[p]);
                }
            }

        }
    }
}


