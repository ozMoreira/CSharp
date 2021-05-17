namespace Contribuintes_POO_Classes_Metodos_Abstratos.Entidades
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double GanhoAnual { get; set; }

        protected Contribuinte(string nome, double ganhoAnual)
        {
            Nome = nome;
            GanhoAnual = ganhoAnual;
        }

        public abstract double Taxa();
    }
}
