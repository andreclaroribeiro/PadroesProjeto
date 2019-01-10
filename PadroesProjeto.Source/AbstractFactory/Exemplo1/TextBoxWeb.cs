using System;

namespace PadroesProjeto.Source.AbstractFactory
{
    public class TextBoxWeb : ITextBox
    {
        public void Criar()
        {
            Console.WriteLine("Caixa de texto Web criada!");
        }
    }
}