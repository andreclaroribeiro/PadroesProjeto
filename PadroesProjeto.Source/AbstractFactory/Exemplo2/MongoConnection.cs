using System;

namespace PadroesProjeto.Source.AbstractFactory
{
    public class MongoConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método Open de Mongo Connection foi chamado...");
        }
    }
}