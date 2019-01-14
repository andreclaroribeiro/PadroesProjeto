using System;

namespace PadroesProjeto.Source.Observer
{
    public class ControladorEmail
    {
        public Action ProcessarEmail;

        public void EnviarEmail()
        {
            ProcessarEmail();
        }
    }
}