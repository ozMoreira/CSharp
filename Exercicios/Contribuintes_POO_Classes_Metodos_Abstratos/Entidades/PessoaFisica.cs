namespace Contribuintes_POO_Classes_Metodos_Abstratos.Entidades
{
    class PessoaFisica : Contribuinte
    {
        public double DespesasMedicas { get; set; }
        public double Impostos { get; set; }

        public PessoaFisica(string nome, double ganhoAnual, double despesasMedicas, double impostos)
            : base(nome, ganhoAnual)
        {
            DespesasMedicas = despesasMedicas;
            Impostos = impostos;
        }

        public override double Taxa()
        {
            return (GanhoAnual * (Impostos / 100)) - (DespesasMedicas * 0.5);
        }


    }
}
