namespace PadroesProjeto.Source.AbstractFactory
{
    public class MongoFactory : DbFactory
    {
        public override DbConnection CreateConnection()
        {
            return new MongoConnection();
        }

        public override DbCommand CreateCommand()
        {
            return new MongoCommand();
        }
    }
}