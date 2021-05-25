using CarRental_POO_ComInterface.Entities;
using System;

namespace CarRental_POO_ComInterface.Services
{
    class ServicoAluguel
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        private IServicoTaxa _servicoTaxa;

        public ServicoAluguel(double precoHora, double precoDia, IServicoTaxa servicoTaxa)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            _servicoTaxa = servicoTaxa;
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

            double tax = _servicoTaxa.Taxa(pagtoBasico);

            aluguel.Invoice = new Invoice(pagtoBasico, tax);

        }
    }
}
