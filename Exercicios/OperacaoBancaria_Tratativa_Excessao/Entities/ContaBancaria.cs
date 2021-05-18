using OperacaoBancaria_Tratativa_Excessao.Exceptions;

namespace OperacaoBancaria_Tratativa_Excessao.Entities
{
    class ContaBancaria
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public ContaBancaria(int numero, string titular, double saldo, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public void Saca(double valor)
        {
            if (valor > LimiteSaque)
            {
                throw new DomainException("Valor desejado para Saque é superior ao Limite permitido para saque!");
            }
            if (valor > Saldo)
            {
                throw new DomainException("Valor desejado é superior ao saldo da Conta!");
            }
            Saldo -= valor;
        }
    }
}
