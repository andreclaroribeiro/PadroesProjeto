using System;
using System.Text;

namespace PadroesProjeto.Source.Decorator
{
    public class PessoaLenta : IPessoa
    {
        IPessoa p;

        public PessoaLenta(IPessoa p)
        {
            this.p = p;
        }

        public string Andar()
        {
            return new StringBuilder(p.Andar())
                .Append(" ")
                .Append("devagar")
                .ToString();
        }
    }
}