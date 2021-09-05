using Processa_Contratos_INTERFACE.Entities;
using Processa_Contratos_INTERFACE.Services;
using System;
using System.Globalization;

namespace Processa_Contratos_INTERFACE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- INFORME OS DADOS DO CONTRATO ---");
            Console.Write("Número >>> ");
            int nroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data do Contrato (dd/MM/yyy) >>> ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.CurrentCulture);
            Console.Write("Valor do Contrato >>> R$ ");
            double valorContrato = double.Parse(Console.ReadLine());
            Console.Write("Informe o numero de parcelas desejadas para pagamento do contrato >>> ");
            int nroParcelas = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(nroContrato, dataContrato, valorContrato);

            Servico_De_Contrato sc = new Servico_De_Contrato(new ServicoPaypal());
            sc.ProcessaContrato(contrato, nroParcelas);

            Console.Clear();
            Console.WriteLine("Plano de Parcelamento:\n");
            double totalAPrazo = 0.0;
            int cont = 0;
            foreach(Parcelas parcela in contrato.Parcelas)
            {
                Console.WriteLine(parcela);
                totalAPrazo += parcela.ValorParcela;
                cont++;
            }
            Console.WriteLine($"\n\nTotal à vista: {contrato.Valor.ToString("F2")}" +
                $"\nTotal à prazo: {totalAPrazo.ToString("F2")} em {cont} vezes*" +
                $"\n\n*(Juros simples de 1% + taxa de pagamento de 2%  a.m.)\n\n\n\n");
        }
    }
}
