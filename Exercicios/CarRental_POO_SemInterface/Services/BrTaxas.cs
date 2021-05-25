namespace CarRental_POO_SemInterface.Services
{
    class BrTaxas
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
