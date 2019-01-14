using System;

namespace PadroesProjeto.Source.Bridge
{
    public class CSharpMail : IMessage
    {
        public void Send()
        {
            Console.WriteLine("E-mail enviado pelo código C#");
        }
    }
}