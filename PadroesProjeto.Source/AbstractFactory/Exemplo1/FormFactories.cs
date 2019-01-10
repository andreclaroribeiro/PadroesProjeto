using System;

namespace PadroesProjeto.Source.AbstractFactory
{
    public static class FormFactories
    {
        public static IFormFactory ObterFactory()
        {
            /* ambientes: 
                 web
                 standalone
                 mobile
             */

            var config = new System.Configuration.AppSettingsReader();
            var ambiente = config.GetValue("ambiente", typeof(System.String)).ToString();

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