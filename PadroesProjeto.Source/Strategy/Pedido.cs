namespace PadroesProjeto.Source.Strategy
{
    public class Pedido
    {
        public int CodigoLocal { get; private set; }
        public int PesoProduto { get; private set; }

        private ICalculadorDeFrete _calculadorDeFrete;
        public Pedido(ICalculadorDeFrete calculadorDeFrete, int codigoLocal, int pesoProduto)
        {
            _calculadorDeFrete = calculadorDeFrete;
            CodigoLocal = codigoLocal;
            PesoProduto = pesoProduto;
        }

        public decimal CalcularFrete()
        {
             return _calculadorDeFrete.CalcularFretePara(this);
        }
    }
}