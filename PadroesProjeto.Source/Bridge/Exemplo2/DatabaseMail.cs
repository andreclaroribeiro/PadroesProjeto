using System;

namespace PadroesProjeto.Source.Bridge
{
    public class DatabaseMail : IMessage
    {
        public void Send()
        {
            Console.WriteLine("E-mail enviado pelo database");
        }
    }
}