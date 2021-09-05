namespace Formatos_Geometricos_COM_INTERFACE
{
    class Retangulo : Abstract_Formato
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Largura * Altura;
        }

        public override string ToString()
        {
            return "Cor do Retangulo = "
                + Cor
                + ", Largura = "
                + Largura.ToString("F2")
                + ", Altura = "
                + Altura.ToString("F2")
                + ", Area = "
                + Area().ToString("F2");
        }
    }
}
