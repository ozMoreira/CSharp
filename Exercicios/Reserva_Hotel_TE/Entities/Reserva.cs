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
