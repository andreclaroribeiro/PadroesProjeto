namespace PadroesProjeto.Source.AbstractFactory
{
    public interface IFormFactory
    {
        IButton CriarBotao();
        ITextBox CriarTextBox();
    }
}