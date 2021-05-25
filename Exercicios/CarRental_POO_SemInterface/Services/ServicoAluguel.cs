using CarRental_POO_SemInterface.Entities;
using System;

namespace CarRental_POO_SemInterface.Services
{
    class ServicoAluguel
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        private BrTaxas _brTaxas = new BrTaxas();

        public ServicoAluguel(double precoHora, double precoDia)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
        }

        public void ProcessaNF(Aluguel aluguel)
        {
            TimeSpan duracao = aluguel.Fim.Subtract(aluguel.Inicio);
            double pagtoBasico = 0.0;
            if (duracao.TotalHours <= 12)
            {
                pagtoBasico = PrecoHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagtoBasico = PrecoDia * Math.Ceiling(duracao.TotalDays);
            }

            double tax = _brTaxas.Taxa(pagtoBasico);

            aluguel.Invoice = new Invoice(pagtoBasico, tax);

        }
    }
}
