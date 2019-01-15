using System;
namespace PadroesProjeto.Source.Mediator
{
    public class SymbianColleague : Colleague
    {
        public SymbianColleague(IMediator mediator) : base(mediator) { }

        public override void ReceberMensagem(string mensagem)
        {
            Console.WriteLine("Symbian recebeu: " + mensagem);
        }
    }
}