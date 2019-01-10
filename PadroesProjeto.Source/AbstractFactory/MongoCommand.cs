using System;

namespace PadroesProjeto.Source.AbstractFactory
{
    public class MongoCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Executando o comando do sql do Mongo.....");
        }
    }
}