namespace Conta_Bancaria_POO {
    class Conta {

        private string _nome;
        public int NroConta { get; private set; }
        public double Saldo { get; private set; }


        public Conta(string nome, int nroConta) {
            this._nome = nome;
            this.NroConta = nroConta;
            this.Saldo = 0;
        }

        public string Nome {
            get { return _nome; }
            set { if(value != null && value.Length > 1) {
                    _nome = value;}
            }
        }

        public override string ToString() {
            return "Correntista: " + _nome +
                "Conta Corrente Nro: " + NroConta +
                "Saldo Atual: R$ " + Saldo.ToString("F2");
        }


    }

}
