using System.Collections.Generic;

namespace PadroesProjeto.Source.Memento
{
    public class TextoCareTaker
    {
        private List<TextoMemento> _estados;

        public TextoCareTaker()
        {
            _estados = new List<TextoMemento>();
        }

        public void AdicionarMemento(TextoMemento memento)
        {
            _estados.Add(memento);
        }

        public TextoMemento GetUltimoEstadoSalvo()
        {
            if (_estados.Count <= 0)
            {
                return new TextoMemento("");
            }

            var estadoSalvo = _estados[_estados.Count - 1];
            _estados.Remove(estadoSalvo);

            return estadoSalvo;
        }
    }
}