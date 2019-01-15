using System;

namespace PadroesProjeto.Source.ChainOfResponsibility
{
    public class BancoB : BancoChain
    {
        public BancoB() : base(BancoEnum.BancoB) { }

        protected override void EfetuaPagamento()
        {
            Console.WriteLine("Pagamento efetuado no banco B");
        }
    }
}