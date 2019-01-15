using System;

namespace PadroesProjeto.Source.ChainOfResponsibility
{
    public abstract class BancoChain
    {
        protected BancoChain next;
        protected BancoEnum identificadorBanco;

        public BancoChain(BancoEnum id)
        {
            next = null;
            identificadorBanco = id;
        }

        public void SetNext(BancoChain forma)
        {
            if (next == null)
            {
                next = forma;
            }
            else
            {
                next.SetNext(forma);
            }
        }

        public void EfetuarPagamento(BancoEnum id) 
        {
            if (PodeEfetuarPagamento(id))
            {
                EfetuaPagamento();
            }
            else
            {
                if (next == null)
                {
                    throw new Exception("banco não cadastrado");
                }
                next.EfetuarPagamento(id);
            }
        }
 
        private bool PodeEfetuarPagamento(BancoEnum id)
        {
            return identificadorBanco == id;
        }

        protected abstract void EfetuaPagamento();
    }
}