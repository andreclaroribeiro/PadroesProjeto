using System;
using System.Collections.Generic;

namespace PadroesProjeto.Source.Mediator
{
    public class MensagemMediator : IMediator
    {
        protected List<Colleague> _contatos;

        public MensagemMediator()
        {
            _contatos = new List<Colleague>();
        }

        public void AdicionarColleague(Colleague colleague)
        {
            _contatos.Add(colleague);
        }

        public void Enviar(string mensagem, Colleague colleague)
        {
            foreach (Colleague contato in _contatos)
            {
                if (contato != colleague)
                {
                    DefinirProtocolo(contato);
                    contato.ReceberMensagem(mensagem);
                }
            }
        }

        private void DefinirProtocolo(Colleague contato)
        {
            if (contato is IOSColleague)
            {
                Console.WriteLine("Protocolo iOS");
            }
            else if (contato is AndroidColleague)
            {
                Console.WriteLine("Protocolo Android");
            }
            else if (contato is SymbianColleague)
            {
                Console.WriteLine("Protocolo Symbian");
            }
        }
    }
}