namespace Aumento_Salarial_POO_Lista {
    class Colaborador {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Colaborador(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void aumentaSalario(double percentual) {
            Salario += ((Salario * percentual) / 100);
        }

      
        public override string ToString() {
            return Id + ", " + Nome + ", " + Salario.ToString("F2");
        }
    }
}
