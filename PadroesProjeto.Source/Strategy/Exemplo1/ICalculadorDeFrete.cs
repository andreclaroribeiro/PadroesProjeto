namespace PadroesProjeto.Source.Strategy
{
    public interface ICalculadorDeFrete
    {
        decimal CalcularFretePara(Pedido pedido);
    }

}