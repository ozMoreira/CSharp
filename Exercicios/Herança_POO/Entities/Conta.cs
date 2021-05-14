namespace ContaBancaria_Herança_POO.Entities
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {

        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double valor)
        {
            Saldo -= valor;
        }

        public void Deposito(double valor)
        {
            Saldo += valor; 
        }
    }
}
