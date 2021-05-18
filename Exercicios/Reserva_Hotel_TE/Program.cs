using Reserva_Hotel_TE.Entities;
using Reserva_Hotel_TE.Entities.Exceptions;
using System;

namespace Reserva_Hotel_TE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número do Quarto >>> ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Data de Chegada (dd/MM/yyy) >>> ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Saída (dd/MM/yyy) >>> ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reserva r = new Reserva(numero, checkIn, checkOut);
                Console.WriteLine($"Reserva: {r}.");

                Console.WriteLine("\n Entre com os dados para atualizar a reserva");
                Console.Write("Data de Chegada (dd/MM/yyy) >>> ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Saída (dd/MM/yyy) >>> ");
                checkOut = DateTime.Parse(Console.ReadLine());

                r.AtualizaDatas(checkIn, checkOut);
                Console.WriteLine($"Reserva Atualizada: {r}.");
            }
            catch (DomainException e)
            {
                Console.WriteLine("ERRO na Reserva: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("ERRO: >>> Número do Quarto <<< só aceita NÚMEROS");
            }

            catch (Exception e) //Pega qualquer outra excessao sem deixar estourar
            {
                Console.WriteLine("ERRO INESPERADO: " + e.Message);
            }
        }
    }
}

