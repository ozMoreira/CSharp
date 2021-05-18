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

        public string AtualizaDatas(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "IMPOSSIVEL ATUALIZAR RESERVA - DATAS PRECISAM SER MAIORES QUE HOJE";
            }
            if (checkOut <= checkIn)
            {
                return "\nErro na Reserva - Data de Saída tem que ser maior que a data de Entrada!";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null; //-> indica que nao houve erro, mas é uma validação que ñão é boa prática

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
