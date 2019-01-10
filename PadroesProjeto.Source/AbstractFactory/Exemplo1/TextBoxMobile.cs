using System;

namespace PadroesProjeto.Source.AbstractFactory
{
    public class TextBoxMobile : ITextBox
    {
        public void Criar()
        {
            Console.WriteLine("Caixa de texto Mobile criada!");
        }
    }
}