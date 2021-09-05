using System;

namespace Processa_Contratos_INTERFACE.Entities
{
    class Parcelas
    {
        public DateTime DataParcela { get; set; }
        public Double ValorParcela { get; set; }

        public Parcelas(DateTime dataParcela, double valorParcela)
        {
            DataParcela = dataParcela;
            ValorParcela = valorParcela;
        }

        public override string ToString()
        {
            return DataParcela.ToString("dd/MM/yyyy")
                + " - "
                + ValorParcela.ToString("F2");
        }
    } //class
} //main
