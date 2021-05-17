using FormatoGeometrico_POO_Metodos_Abstratos.Entities.Enums;

namespace FormatoGeometrico_POO_Metodos_Abstratos.Entities
{
    class Retangulo : Formato
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cor cor)
            : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
