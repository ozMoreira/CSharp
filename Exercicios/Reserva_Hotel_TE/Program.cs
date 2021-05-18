using Reserva_Hotel_TE.Entities;
using System;

namespace Reserva_Hotel_TE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número do Quarto >>> ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Data de Chegada (dd/MM/yyy) >>> ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Data de Saída (dd/MM/yyy) >>> ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("\nErro na Reserva - Data de Saída tem que ser maior que a data de Entrada!");
            }
            else
            {
                Console.WriteLine("\nReserva efetuada com SUCESSO!");
                Reserva r = new Reserva(numero, checkIn, checkOut);
                Console.WriteLine($"Reserva: {r}.");

                Console.WriteLine("\n Entre com os dados para atualizar a reserva");
                Console.Write("Data de Chegada (dd/MM/yyy) >>> ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Saída (dd/MM/yyy) >>> ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("IMPOSSIVEL ATUALIZAR RESERVA - DATAS PRECISAM SER MAIORES QUE HOJE");
                }
                else
                {

                    if (checkOut <= checkIn)
                    {
                        Console.WriteLine("\nErro na Reserva - Data de Saída tem que ser maior que a data de Entrada!");
                    }
                    else
                    {
                        Console.WriteLine("\nReserva efetuada com SUCESSO!");
                        r.AtualizaDatas(checkIn, checkOut);
                        Console.WriteLine($"Reserva Atualizada: {r}.");
                    }
                }

            }

        }
    }
}
