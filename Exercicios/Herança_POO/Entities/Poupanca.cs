using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria_Herança_POO.Entities
{
    class Poupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public Poupanca()
        {

        }

        public Poupanca(int numero, string titular, double saldo, double taxaJuros) 
            : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizaSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
    }
}
