namespace CarRental_POO_ComInterface.Services
{
    class BrTaxas : IServicoTaxa
    {
        public double Taxa(double total)
        {
            if (total <= 100.0)
            {
                return total * 0.2;
            }
            else
            {
                return total * 0.15;
            }
        }

    }
}
