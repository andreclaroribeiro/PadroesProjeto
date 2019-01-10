namespace PadroesProjeto.Source.AbstractFactory
{
    public class FormWebFactory : IFormFactory
    {
        public IButton CriarBotao()
        {
            return new ButtonWeb();
        }

        public ITextBox CriarTextBox()
        {
            return new TextBoxWeb();
        }
    }
}