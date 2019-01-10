using System;

namespace PadroesProjeto.Source.AbstractFactory
{
    public static class FormFactories
    {
        public static IFormFactory ObterFactory(string ambiente)
        {           
            if (ambiente == "web")
            {
                return new FormWebFactory();
            }
            else if (ambiente == "standalone")
            {
                return new FormStandAloneFactory();
            }
            else if (ambiente == "mobile")
            {
                return new FormMobileFactory();
            }
            else
            {
                throw new Exception("Ambiente não suportado!");
            }
        }
    }
}