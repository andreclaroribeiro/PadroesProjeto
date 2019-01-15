namespace PadroesProjeto.Source.Mediator
{
    public interface IMediator
    {
        void Enviar(string mensagem, Colleague colleague);
    }
}