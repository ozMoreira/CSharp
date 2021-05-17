namespace ContasBancarias_POO_ClasseAbastract.Entities
{
    class ContaCorporativa : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaCorporativa()
        {
        }

        public ContaCorporativa(int numero, string titular, double saldo, double limiteEmprestimo)
            : base(numero, titular, saldo)
        {

            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                Saldo += valor;
            }

        }
    }
}
