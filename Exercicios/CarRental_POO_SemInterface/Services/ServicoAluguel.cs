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
            //calcula a duraçao da locação, subtraindo o fim da locação com o inicio
            TimeSpan duracao = aluguel.Fim.Subtract(aluguel.Inicio);
            double pagtoBasico = 0.0;

            //se a duração for menor ou igual a 12, o valor a cobrar é por hora
            if (duracao.TotalHours <= 12)
            {
                //math.ceiling arredonda pra cima
                pagtoBasico = PrecoHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagtoBasico = PrecoDia * Math.Ceiling(duracao.TotalDays);
            }

            //calcula o imposto, baseado no pagamento basico calculado acima
            double tax = _brTaxas.Taxa(pagtoBasico);

            //monta a nf com o valor a ser cobrado + taxas
            aluguel.Invoice = new Invoice(pagtoBasico, tax);

        }
    }
}
