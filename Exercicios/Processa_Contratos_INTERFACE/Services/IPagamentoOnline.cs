using System;
using System.Collections.Generic;
using System.Text;

namespace Processa_Contratos_INTERFACE.Services
{
    interface IPagamentoOnline
    {
        double TaxaPagamento(double total);
        double AcrescimoMensal(double total, int meses);

    }
}
