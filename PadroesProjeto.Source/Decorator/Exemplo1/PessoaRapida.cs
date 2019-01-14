using System.Text;

namespace PadroesProjeto.Source.Decorator
{
    public class PessoaRapida : IPessoa
    {
        IPessoa p;

        public PessoaRapida(IPessoa p)
        {
            this.p = p;
        }

        public string Andar()
        {
            return new StringBuilder(p.Andar())
                    .Append(" ")
                    .Append("rápido")
                    .ToString();
        }

        public string Correr()
        {
            return "Corri";
        }
    }
}