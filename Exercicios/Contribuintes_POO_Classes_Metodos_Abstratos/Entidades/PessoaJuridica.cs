namespace Contribuintes_POO_Classes_Metodos_Abstratos.Entidades
{
    class PessoaJuridica : Contribuinte
    {
        public int TotalEmpregados { get; set; }
        public double Impostos { get; set; }

        public PessoaJuridica(string nome, double ganhoAnual, int totalEmpregados, double impostos)
            : base(nome, ganhoAnual)
        {
            TotalEmpregados = totalEmpregados;
            Impostos = impostos;
        }

        public override double Taxa()
        {
            
            return GanhoAnual * (Impostos/100);
        }
    }
}
