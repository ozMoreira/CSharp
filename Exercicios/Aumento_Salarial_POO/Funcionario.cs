using System;
using System.Collections.Generic;
using System.Text;

namespace Aumento_Salarial_POO {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double CalculaLiquido(double salarioLiquido) {
            return salarioLiquido = SalarioBruto - Imposto;
        }

        public void AumentarSalario(double percentual) {
            SalarioBruto += (SalarioBruto * 10) / 100;
        }

        public override string ToString() {
            return "\n   Nome: " + Nome +
                "\n   Salário Bruto: R$ " + SalarioBruto.ToString("F2") +
                "\n   Impostos Descontados na Folha: R$ " + Imposto.ToString("F2") +
                "\n   Salário Liquido: R$ " + CalculaLiquido(SalarioBruto).ToString("F2");
        }
    }
}
