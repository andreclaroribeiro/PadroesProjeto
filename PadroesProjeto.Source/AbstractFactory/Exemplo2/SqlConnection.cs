using System;

namespace PadroesProjeto.Source.AbstractFactory
{
    public class SqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método Open de SQL Connection foi chamado...");
        }
    }
}