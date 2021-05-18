using Reserva_Hotel_TE.Entities.Exceptions;
using System;

namespace Reserva_Hotel_TE.Entities
{
    class Reserva
    {
        public int NroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva()
        {

        }

        public Reserva(int nroQuarto, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("\nErro na Reserva - Data de Saída tem que ser maior que a data de Entrada!");
            }
            NroQuarto = nroQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;
        }

        public void AtualizaDatas(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("IMPOSSIVEL ATUALIZAR RESERVA - DATAS PRECISAM SER MAIORES QUE HOJE");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("\nErro na Reserva - Data de Saída tem que ser maior que a data de Entrada!");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Quarto "
                + NroQuarto
                + ", Check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", Check-out: "
                + CheckOut.ToString("dd/MM/yyy")
                + ", "
                + Duracao()
                + " noites";
        }
    }
}
