using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Funcionarios_POO_Heranca_Polimorfismo.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Horas { get; set; }

        public double ValorHora { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, double horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorHora;
        }
    }
}
