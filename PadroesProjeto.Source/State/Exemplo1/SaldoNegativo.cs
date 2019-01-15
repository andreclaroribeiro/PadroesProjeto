using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Source.State
{
    public class SaldoNegativo : IContaState
    {
        private Conta _conta;

        public SaldoNegativo(Conta conta)
        {
            _conta = conta;
        }

        public void Deposito(double valor)
        {
            _conta.Saldo += valor;

            Console.WriteLine("Foi depositado R$ {0}, saldo atual R$ {1}", valor, this._conta.Saldo);

            if (_conta.Saldo >= -100.00)
                if (_conta.Saldo < 0)
                    _conta.MeuEstado = new SaldoNegativo(_conta);
                else
                    _conta.MeuEstado = new SaldoPositivo(_conta);
        }

        public void Saque(double valor)
        {
            _conta.Saldo -= valor;

            Console.WriteLine("Retirado R$ {0}, saldo atual R$ {1}.", valor, _conta.Saldo);


            if (_conta.Saldo < -100.00)
                _conta.MeuEstado = new Bloqueado(_conta);
        }
    }
}