namespace PadroesProjeto.Source.Strategy
{
    public class CalculadorDeFretePadrao : ICalculadorDeFrete
    {
        public decimal CalcularFretePara(Pedido pedido)
        {
            return pedido.CodigoLocal * pedido.PesoProduto;
        }
    }
}
