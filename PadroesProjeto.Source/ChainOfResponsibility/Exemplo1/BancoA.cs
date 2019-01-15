using System;

namespace PadroesProjeto.Source.ChainOfResponsibility
{
    public class BancoA : BancoChain
    {
        public BancoA(): base(BancoEnum.BancoA) { }

        protected override void EfetuaPagamento()
        {
            Console.WriteLine("Pagamento efetuado no banco A");
        }
    }
}