namespace PadroesProjeto.Source.AbstractFactory
{
    public class SqlFactory : IDbEngine
    {
        public DbConnection CreateConnection()
        {
            return new SqlConnection();
        }

        public DbCommand CreateCommand()
        {
            return new SqlCommand();
        }
    }
}