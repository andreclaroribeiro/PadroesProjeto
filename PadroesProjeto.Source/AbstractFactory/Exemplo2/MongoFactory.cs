namespace PadroesProjeto.Source.AbstractFactory
{
    public class MongoFactory : IDbEngine
    {
        public DbConnection CreateConnection()
        {
            return new MongoConnection();
        }

        public DbCommand CreateCommand()
        {
            return new MongoCommand();
        }
    }
}