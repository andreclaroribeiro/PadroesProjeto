namespace PadroesProjeto.Source.AbstractFactory
{
    public class SqlFactory : DbFactory
    {
        public override DbConnection CreateConnection()
        {
            return new SqlConnection();
        }

        public override DbCommand CreateCommand()
        {
            return new SqlCommand();
        }
    }
}