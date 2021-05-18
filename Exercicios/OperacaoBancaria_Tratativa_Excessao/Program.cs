using OperacaoBancaria_Tratativa_Excessao.Entities;
using OperacaoBancaria_Tratativa_Excessao.Exceptions;
using System;

namespace OperacaoBancaria_Tratativa_Excessao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Entre com os dados da Conta Bancária -----");
            Console.Write("Número >>> ");
            int nro = int.Parse(Console.ReadLine());
            Console.Write("Titular >>> ");
            string nome = Console.ReadLine();
            Console.Write("Saldo Inicial >>> R$ ");
            double saldo = double.Parse(Console.ReadLine());
            Console.Write("Limite de Saque >>> R$ ");
            double limiteSaque = double.Parse(Console.ReadLine());

            ContaBancaria c = new ContaBancaria(nro, nome, saldo, limiteSaque);
            Console.WriteLine("\n-----------------------------------------------");
            Console.Write("\n Informe o valor para Saque >>> R$ ");
            double valor = double.Parse(Console.ReadLine());

            try
            {
                c.Saca(valor);
                Console.WriteLine($" Novo Saldo >>> R$ {c.Saldo.ToString("F2")}");
            }
            catch (DomainException e)
            {
                Console.WriteLine("ERRO NA OPERAÇÃO: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("ERRO - DADO INVÁLIDO: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO GENERICO - ENTRE EM CONTATO COM O SUPORTE");
            }
        }
    }
}
