using System;
using System.Collections.Generic;
using System.Text;

namespace Reservas_Hotel_POO_Arranjos {
    class Reserva {

        public int NroReserva { get; private set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NroQuarto { get; private set; }

        public Reserva(int reserva, string nome, string email, int quarto) {
            this.NroReserva = reserva;
            this.Nome = nome;
            this.Email = email;
            this.NroQuarto = quarto;
        }

        public Reserva(int quarto) {
            this.NroQuarto = quarto;
        }
     
        public override string ToString() {
            return "\n\nBooking # " + NroQuarto +
                "\nHóspede Principal: " + Nome +
                "\nE-mail: " + Email +
                "\nQuarto # " + NroQuarto;
        }

    }
}
