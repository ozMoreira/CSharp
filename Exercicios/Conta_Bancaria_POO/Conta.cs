namespace Conta_Bancaria_POO {
    class Conta {

        public  string _nome { get; set; }
        public int NroConta { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string nome, int nroConta) {
            this._nome = nome;
            this.NroConta = nroConta;
        }
        public Conta(string nome, int nroConta, double saldo) : this(nome, nroConta) { 
            this.Saldo = saldo;
        }

        public string Nome {
            get { return _nome; }
            set { if(value != null && value.Length > 1) {
                    _nome = value;}
            }
        }

        public void Deposita(double deposita) {
            this.Saldo += deposita;
        }

        public void Saca(double saque) {
            this.Saldo -= (saque + 5);
        }


        public override string ToString() {
            return "\nCorrentista: " + _nome +
                "\nConta Corrente Nro: " + NroConta +
                "\nSaldo Atual: R$ " + Saldo.ToString("F2");
        }


    }

}
