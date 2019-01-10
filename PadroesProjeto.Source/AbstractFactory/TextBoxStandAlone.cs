using System;

namespace PadroesProjeto.Source.AbstractFactory
{
    public class TextBoxStandAlone : ITextBox
    {
        public void Criar()
        {
            Console.WriteLine("Caixa de texto Stand-alone criada!");
        }
    }
}