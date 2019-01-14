using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Source.Bridge
{
    public class VbMail : IMessage
    {
        public void Send()
        {
            Console.WriteLine("E-mail enviado pelo código VB");
        }
    }
}