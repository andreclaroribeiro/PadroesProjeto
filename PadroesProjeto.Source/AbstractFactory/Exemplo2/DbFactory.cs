namespace PadroesProjeto.Source.AbstractFactory
{
    public class DbFactory
    {
        public static IDbEngine Criar()
        {
            var config = new System.Configuration.AppSettingsReader();
            var dbType = config.GetValue("DbType", typeof(System.String)).ToString();

            if (dbType.Equals("mongo"))
            {
                return new MongoFactory();
            }
            else if (dbType.Equals("sql"))
            {
                return new SqlFactory();
            }
            else
            {
                throw new System.NotImplementedException();
            }
        }
    }
}