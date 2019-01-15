using System;

namespace PadroesProjeto.Source.Mediator
{
    public class AndroidColleague : Colleague
    {
        public AndroidColleague(IMediator mediator) : base(mediator) { }

        public override void ReceberMensagem(string mensagem)
        {
            Console.WriteLine("Android recebeu: " + mensagem);
        }
    }
}