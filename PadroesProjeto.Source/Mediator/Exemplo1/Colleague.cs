namespace PadroesProjeto.Source.Mediator
{
    public abstract class Colleague
    {
        protected IMediator _mediator;
        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void EnviarMensagem(string mensagem)
        {
            _mediator.Enviar(mensagem, this);
        }

        public abstract void ReceberMensagem(string mensagem);
    }
}