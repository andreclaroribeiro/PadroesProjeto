using System;

namespace PadroesProjeto.Source.Memento
{
    public class Texto
    {
        private string _texto;
        TextoCareTaker _caretaker;

        public Texto()
        {
            _caretaker = new TextoCareTaker();
            _texto = string.Empty;
        }

        public void EscreverTexto(string novoTexto)
        {
            _caretaker.AdicionarMemento(new TextoMemento(_texto));
            _texto += novoTexto;
        }

        public void DesfazerEscrita()
        {
            _texto = _caretaker.GetUltimoEstadoSalvo().TextoSalvo;
        }

        public void MostrarTexto()
        {
            Console.WriteLine(_texto);
        }
    }
}