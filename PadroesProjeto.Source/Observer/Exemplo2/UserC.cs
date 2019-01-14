using System;

namespace PadroesProjeto.Source.Observer
{
    public class UserC : IObserver<Email>
    {
        private IDisposable _disposer;

        public UserC(IObservable<Email> controladorEmail)
        {
            _disposer = controladorEmail.Subscribe(this);
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Email value)
        {
            Console.WriteLine(value.Descricao + "C");
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }
}