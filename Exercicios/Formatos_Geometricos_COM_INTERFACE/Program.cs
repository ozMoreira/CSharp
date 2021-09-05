using Formatos_Geometricos_COM_INTERFACE.Model.Entities;

namespace Formatos_Geometricos_COM_INTERFACE
{
    class Program
    {
        static void Main(string[] args)
        {

            IFormato f1 = new Circulo() { Raio = 2.0, Cor = Cor.Azul };
            IFormato f2 = new Retangulo() { Largura = 3.5, Altura = 4.2, Cor = Cor.Vermelho };

            System.Console.WriteLine(f1);
            System.Console.WriteLine(f2);
        }
    }
}
