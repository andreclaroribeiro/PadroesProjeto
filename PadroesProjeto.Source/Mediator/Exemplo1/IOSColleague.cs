using System;

namespace PadroesProjeto.Source.Mediator
{
    public class IOSColleague : Colleague
    {
        public IOSColleague(IMediator mediator) : base(mediator) { }

        public override void ReceberMensagem(string mensagem)
        {
            Console.WriteLine("iOs recebeu: " + mensagem);
        }
    }
}