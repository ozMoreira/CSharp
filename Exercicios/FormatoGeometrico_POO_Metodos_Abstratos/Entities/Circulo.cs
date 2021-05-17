using FormatoGeometrico_POO_Metodos_Abstratos.Entities.Enums;
using System;

namespace FormatoGeometrico_POO_Metodos_Abstratos.Entities
{
    class Circulo : Formato
    {
        public double Raio { get; set; }

        public Circulo(double raio, Cor cor)
            : base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
