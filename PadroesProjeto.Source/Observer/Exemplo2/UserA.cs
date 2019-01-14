using System;

namespace PadroesProjeto.Source.Observer
{
    public class UserA : IObserver<Email>
    {
        private IDisposable _disposer;

        public UserA(IObservable<Email> controladorEmail)
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
            Console.WriteLine(value.Descricao + "A");
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }
}