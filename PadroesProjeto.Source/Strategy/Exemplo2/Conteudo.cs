namespace PadroesProjeto.Source.Strategy
{
    public class Conteudo
    {
        private IComissao _comissao;

        public Conteudo(IComissao comissao)
        {
            _comissao = comissao;
        }

        public double CalculaComissao(double totalVenda, double percentual)
        {
            return _comissao.CalcularComissao(totalVenda, percentual);
        }
    }
}