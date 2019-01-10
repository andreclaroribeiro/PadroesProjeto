namespace PadroesProjeto.Source.Strategy
{
    public class ComissaoIndividual : IComissao
    {
        public double CalcularComissao(double totalVenda, double percentual)
        {
            return ((totalVenda * percentual) / 100);
        }
    }
}