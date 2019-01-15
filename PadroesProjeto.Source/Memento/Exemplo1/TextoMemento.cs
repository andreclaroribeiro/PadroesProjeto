namespace PadroesProjeto.Source.Memento
{
    public class TextoMemento
    {
        public string TextoSalvo { get; private set; }

        public TextoMemento(string texto)
        {
            TextoSalvo = texto;
        }
    }
}