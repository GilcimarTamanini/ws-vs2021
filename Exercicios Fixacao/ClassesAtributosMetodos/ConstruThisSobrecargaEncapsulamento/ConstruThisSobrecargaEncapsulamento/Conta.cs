using System.Globalization;

namespace ConstruThisSobrecargaEncapsulamento
{
    class Conta
    {
        private string _titular;
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        private double taxa = 5.00;

        public Conta()
        {
        }

        public Conta(string titular, int numConta)
        {
            Titular = titular;
            NumeroConta = numConta;
        }

        public Conta(string titular, int numConta, double depositoInicial) : this(titular, numConta)
        {
            Depositar(depositoInicial);
        }

        public string Titular
        {
            get { return _titular; }
            set
            {
                if ((value != null) && (value.Length > 3))
                {
                    _titular = value;
                }
            }
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(double saque) 
        {
            Saldo -= (saque + taxa);
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta.ToString()
                + ", Titular: "
                + _titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
