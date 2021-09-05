namespace Processa_Contratos_INTERFACE.Services
{
    class ServicoPaypal : IPagamentoOnline
    {
        private const double PercetualTaxas = 0.02;
        private const double Acrescimo = 0.01;
        public double AcrescimoMensal(double total, int meses)
        {
            return total * Acrescimo * meses;
        }

        public double TaxaPagamento(double total)
        {
            return total * PercetualTaxas;
        }
    }
}
