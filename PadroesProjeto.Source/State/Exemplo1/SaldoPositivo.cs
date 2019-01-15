using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Source.State
{
    public class SaldoPositivo : IContaState
    {
        private Conta _conta;

        public SaldoPositivo(Conta conta)
        {
            _conta = conta;
        }
        public void Saque(double valor)
        {
            _conta.Saldo -= valor;

            Console.WriteLine("Retirado R$ {0}, saldo atual R$ {1}.", valor, _conta.Saldo);

            if (_conta.Saldo < 0)
                if (_conta.Saldo < -100.00)
                    _conta.MeuEstado = new Bloqueado(this._conta);
                else
                    _conta.MeuEstado = new SaldoNegativo(this._conta);
        }

        public void Deposito(double valor)
        {
            _conta.Saldo += valor;

            Console.WriteLine("Foi depositado R$ {0}, saldo atual R$ {1}", valor, _conta.Saldo);

            if (_conta.Saldo < 0)
                if (_conta.Saldo < -100.00)
                    _conta.MeuEstado = new Bloqueado(this._conta);
                else
                    _conta.MeuEstado = new SaldoNegativo(this._conta);
        }
    }
}