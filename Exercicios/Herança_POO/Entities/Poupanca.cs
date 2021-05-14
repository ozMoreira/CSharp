using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria_Herança_POO.Entities
{
   sealed class Poupanca : Conta //sealed - evita que a classe seja herdada...lacra a classe
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

        public sealed override void Saque(double valor) // sealed evita que esse metodo seja reesscrito novamente em outra subclasse
        {
            //Saldo -= valor; - saca sem abater os 5 reais da conta base
            base.Saque(valor);
            Saldo -= 2.0;
        }
    }
}
