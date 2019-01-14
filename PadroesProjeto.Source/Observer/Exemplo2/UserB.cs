using System;

namespace PadroesProjeto.Source.Observer
{
    public class UserB : IObserver<Email>
    {
        private IDisposable _disposer;

        public UserB(IObservable<Email> controladorEmail)
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
            Console.WriteLine(value.Descricao + "B");
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }
}