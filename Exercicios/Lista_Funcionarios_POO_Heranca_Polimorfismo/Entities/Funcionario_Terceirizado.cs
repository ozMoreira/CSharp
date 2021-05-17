using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Funcionarios_POO_Heranca_Polimorfismo.Entities
{
    class Funcionario_Terceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public Funcionario_Terceirizado()
        {

        }

        public Funcionario_Terceirizado(string nome, double horas, double valorHora, double despesaAdicional)
            : base(nome, horas, valorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }
    }
}
