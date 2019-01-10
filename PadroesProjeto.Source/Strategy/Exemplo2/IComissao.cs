namespace PadroesProjeto.Source.Strategy
{
    public interface IComissao
    {
        double CalcularComissao(double totalVenda, double percentual);
    }
}