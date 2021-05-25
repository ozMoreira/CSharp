using CarRental_POO_ComInterface.Entities;
using CarRental_POO_ComInterface.Services;
using System;
using System.Globalization;

namespace CarRental_POO_ComInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRE COM OS DADOS DO ALUGUEL");
            Console.Write("Modelo >>> ");
            string modelo = Console.ReadLine();
            Console.Write("Data de Retirada (dd/mm/aaa hh:mm)>>> ");
            DateTime retira = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture);
            Console.Write("Data de Retorno (dd/mm/aaa hh:mm)>>> ");
            DateTime retorna = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture);

            Console.Write("Preço por Hora >>> R$ ");
            double pHora = double.Parse(Console.ReadLine());
            Console.Write("Preço por Dia >>> R$ ");
            double pDia = double.Parse(Console.ReadLine());

            Aluguel al = new Aluguel(retira, retorna, (new Veiculo(modelo)));

            ServicoAluguel sA = new ServicoAluguel(pHora, pDia, new BrTaxas());

            sA.ProcessaNF(al);

            Console.WriteLine("\n\nINVOICE:" );
            Console.WriteLine(al.Invoice);


        }
    }
}
