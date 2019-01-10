namespace PadroesProjeto.Source.AbstractFactory
{
    public class FormMobileFactory : IFormFactory
    {
        public IButton CriarBotao()
        {
            return new ButtonMobile();
        }

        public ITextBox CriarTextBox()
        {
            return new TextBoxMobile();
        }
    }
}