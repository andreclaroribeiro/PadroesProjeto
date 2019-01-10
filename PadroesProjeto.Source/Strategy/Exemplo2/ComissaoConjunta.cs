namespace PadroesProjeto.Source.Strategy
{
    public class ComissaoConjunta : IComissao
    {
        public double CalcularComissao(double totalVenda, double percentual)
        {
            percentual = percentual / 2;
            return ((totalVenda * percentual) / 100);
        }
    }
}