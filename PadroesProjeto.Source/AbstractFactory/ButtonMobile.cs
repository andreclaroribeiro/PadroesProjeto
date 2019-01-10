using System;

namespace PadroesProjeto.Source.AbstractFactory
{
    public class ButtonMobile : IButton
    {
        public void Criar()
        {
            Console.WriteLine("Botão Mobile criado!");
        }
    }
}