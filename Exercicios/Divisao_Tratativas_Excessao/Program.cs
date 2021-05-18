 
using System;

namespace Divisao_Tratativas_Excessao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int resultado = n1 / n2;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é permitido a divisão por Zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Utilize somente números para realizar a divisão");
            }


        }
    }
}
