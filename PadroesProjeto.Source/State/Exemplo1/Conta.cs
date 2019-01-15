using System;

namespace PadroesProjeto.Source.State
{
    public class Conta
    {
        public double Saldo { get; set; }
        public IContaState MeuEstado;

        public Conta()
        {
            Saldo = 0;
        }

        public Conta(double valor)
        {
            MeuEstado = new SaldoPositivo(this);
            Deposito(valor);
        }

        public void Saque(double valor)
        {
            MeuEstado.Saque(valor);
            Console.WriteLine("Estado da conta: {0}\n", MeuEstado.ToString());
        }

        public void Deposito(double valor)
        {
            MeuEstado.Deposito(valor);
            Console.WriteLine("Estado da conta: {0}\n", MeuEstado.ToString());
        }
    }
}