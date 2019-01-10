using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesProjeto.Source.AbstractFactory
{
    public class FormStandAloneFactory : IFormFactory
    {
        public IButton CriarBotao()
        {
            return new ButtonStandAlone();
        }

        public ITextBox CriarTextBox()
        {
            return new TextBoxStandAlone();
        }
    }
}