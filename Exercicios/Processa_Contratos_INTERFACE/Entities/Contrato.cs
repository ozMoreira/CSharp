using System;
using System.Collections.Generic;

namespace Processa_Contratos_INTERFACE.Entities
{
    class Contrato
    {
        public int Nro { get; set; }
        public DateTime Data { get; set; }
        public Double Valor { get; set; }
        public List<Parcelas> Parcelas { get; set; }

        public Contrato(int nro, DateTime data, double valor)
        {
            Nro = nro;
            Data = data;
            Valor = valor;
            Parcelas = new List<Parcelas>();
        }

        public void AddParcela (Parcelas novaParcela)
        {
            Parcelas.Add(novaParcela);
        }

        public void RemoveParcela (Parcelas parcelaCadastrada)
        {
            Parcelas.Remove(parcelaCadastrada);
        }
    }
}
