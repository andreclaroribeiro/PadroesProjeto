namespace PadroesProjeto.Source.AbstractFactory
{
    public interface IDbEngine
    {
        DbConnection CreateConnection();

        DbCommand CreateCommand();
    }
}