using System;

namespace PadroesProjeto.Source.ChainOfResponsibility
{
    public class BancoC : BancoChain
    {
        public BancoC() : base(BancoEnum.BancoC) { }

        protected override void EfetuaPagamento()
        {
            Console.WriteLine("Pagamento efetuado no banco C");
        }
    }
}