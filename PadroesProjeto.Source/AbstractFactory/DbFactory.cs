namespace PadroesProjeto.Source.AbstractFactory
{
    public abstract class DbFactory
    {
        public abstract DbConnection CreateConnection();
 
        public abstract DbCommand CreateCommand();
    }
}