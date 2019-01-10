using System;

namespace PadroesProjeto.Source.AbstractFactory
{
    public class ButtonStandAlone : IButton
    {
        public void Criar()
        {
            Console.WriteLine("Botão Stand-alone criado!");
        }
    }
}