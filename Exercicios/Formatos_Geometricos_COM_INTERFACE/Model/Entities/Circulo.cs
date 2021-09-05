using System;

namespace Formatos_Geometricos_COM_INTERFACE
{
    class Circulo : Abstract_Formato
    {
        public double Raio { get; set; }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }

        public override string ToString()
        {
            return "Cor do Circulo = "
                + Cor
                + ", Raio = "
                + Raio.ToString("F2")
                + ", Area = "
                + Area().ToString("F2");
        }
    }
}
