namespace CarRental_POO_SemInterface.Entities
{
    class Invoice
    {
        public double PagtoBasico { get; set; }
        public double Taxas { get; set; }

        public Invoice(double pagtoBasico, double taxas)
        {
            PagtoBasico = pagtoBasico;
            Taxas = taxas;
        }

        public double PagtoTotal
        {
            get { return PagtoBasico + Taxas; }
        }

        public override string ToString()
        {
            return "Pagamento Básico: R$ "
                + PagtoBasico.ToString("F2")
                + "\nTaxas: R$ "
                + Taxas.ToString("F2")
                + "\nPagamento Total: R$ "
                + PagtoTotal.ToString("F2");
        }
    }
}
