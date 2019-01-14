using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Source.Observer
{
    public class EmailController : IObservable<Email>
    {
        public List<IObserver<Email>> _usuarios;
        public Email _email;

        public EmailController(Email email)
        {
            _usuarios = new List<IObserver<Email>>();
            _email = email;
        }

        public IDisposable Subscribe(IObserver<Email> usuario)
        {
            if (!_usuarios.Contains(usuario))
                _usuarios.Add(usuario);

            return new Disposer(_usuarios, usuario);
        }

        public void EnviarEmail()
        {
            _email.Descricao = "Email Enviado para o usuário";

            foreach (IObserver<Email> usuario in _usuarios)
            {
                usuario.OnNext(_email);
            }
        }
    }
}