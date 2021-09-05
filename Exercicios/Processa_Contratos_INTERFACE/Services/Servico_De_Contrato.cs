using Processa_Contratos_INTERFACE.Entities;
using System;

namespace Processa_Contratos_INTERFACE.Services
{
    class Servico_De_Contrato
    {
        IPagamentoOnline _pagamentoOnline;

        public Servico_De_Contrato(IPagamentoOnline pagamentoOnline)
        {
            _pagamentoOnline = pagamentoOnline;
        }

        public void ProcessaContrato(Contrato contrato, int meses)
        {
            double parcelaBase = contrato.Valor / meses;
            for (int i =0; i < meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double atualizaParcela = parcelaBase + _pagamentoOnline.AcrescimoMensal(parcelaBase, i);
                double ValorFinalParcela = atualizaParcela + _pagamentoOnline.TaxaPagamento(atualizaParcela);
                contrato.AddParcela(new Parcelas(data, ValorFinalParcela));
            }
        }
    }
}
