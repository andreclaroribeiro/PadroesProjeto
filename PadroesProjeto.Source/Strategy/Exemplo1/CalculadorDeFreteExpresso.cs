namespace PadroesProjeto.Source.Strategy
{
    public class CalculadorDeFreteExpresso : ICalculadorDeFrete
    {
        public decimal CalcularFretePara(Pedido pedido)
        {
            var fatorExpresso = 1.5;

            return (pedido.CodigoLocal * pedido.PesoProduto) * (decimal)fatorExpresso;
        }
    }
}