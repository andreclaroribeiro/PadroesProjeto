using System;
using System.Collections.Generic;

namespace PadroesProjeto.Source.Observer
{
    public class Disposer : IDisposable
    {
        private List<IObserver<Email>> _usuarios;
        private IObserver<Email> _usuario;

        public Disposer(List<IObserver<Email>> usuarios, IObserver<Email> usuario)
        {
            _usuarios = usuarios;
            _usuario = usuario;
        }

        public void Dispose()
        {
            if (_usuarios.Contains(_usuario))
                _usuarios.Remove(_usuario);
        }
    }
}