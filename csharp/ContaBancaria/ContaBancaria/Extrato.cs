
namespace ContaBancaria
{
    internal class Extrato
    {
        public string Name {  get;  set; }
        public int Conta { get; private set; }
        public double Saldo { get; private set; }
        private readonly double Tax = 5.00;

        public Extrato(string name, int conta )
        {
            Name = name;
            Conta = conta;
        }

        public Extrato(string name, int conta, double saldo): this(name, conta)
        {
            Saldo = saldo;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= (saque + Tax);
        }

        public override string ToString()
        {
            return $"Conta {Conta}, Titular {Name}, Saldo: ${Saldo.ToString("F2")}";
        }

    }
}
