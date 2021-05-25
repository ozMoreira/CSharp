using System;

namespace CarRental_POO_SemInterface.Entities
{
    class Aluguel
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Veiculo { get; set; }
        public Invoice Invoice { get; set; }

        public Aluguel(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;

        }
    }
}
