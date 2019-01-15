using System;

namespace PadroesProjeto.Source.ChainOfResponsibility
{
    public class BancoD : BancoChain
    {
        public BancoD() : base(BancoEnum.BancoD) { }

        protected override void EfetuaPagamento()
        {
            Console.WriteLine("Pagamento efetuado no banco D");
        }
    }
}